package me.Broadcast;

import org.bukkit.Bukkit;
import org.bukkit.ChatColor;
import org.bukkit.command.Command;
import org.bukkit.command.CommandSender;
import org.bukkit.configuration.file.FileConfiguration;
import org.bukkit.entity.Player;
import org.bukkit.event.Listener;
import org.bukkit.plugin.java.JavaPlugin;
import org.bukkit.scheduler.BukkitRunnable;
import java.util.ArrayList;
import java.util.List;

public class Main extends JavaPlugin implements Listener {

    int count = 0;
    int lengte = 0;
    public String host = "[Broadcast++] ";
    FileConfiguration config = this.getConfig();
    List<String> messages = new ArrayList<>();
    List<String> messageNames = new ArrayList<>();
    public String cmd1 = "broadcastSet";
    public String cmd2 = "broadcastRemove";
    public String cmd3 = "broadcastList";
    public String cmd4 = "broadcastDo";
    String message = "";
    Boolean toggle = false;

    @Override
    public void onEnable()
    {
        loadConfig();
        lengte = (int) config.get("Variables." + "lengte", "lengte");
        count = (int) config.get("Variables." + "lengte", "count");
        for(int i = 0; i < lengte; i++)
        {
            messages.add((String) config.get("broadcast." + i,  "message"));
            messageNames.add((String) config.get("broadcastNames." + i, "message"));
        }
        loopBroadcast();
    }

    @Override
    public void onDisable()
    {
        for(int i = 0; i < lengte; i++)
        {
            config.set("broadcastNames." + i, messageNames.get(i));
            config.set("broadcast." + i, messages.get(i));
        }
        config.set("Variables." + "lengte", lengte);
        config.set("Variables." + "count", count);
        this.saveDefaultConfig();
        saveConfig();
    }

    public void loadConfig()
    {
        config.options().copyDefaults(true);
        saveConfig();
    }

    public void loopBroadcast()
    {
        new BukkitRunnable()
        {
            @Override
            public void run()
            {
                if (lengte == count)
                {
                    count = 0;
                }
                Bukkit.broadcastMessage((ChatColor.RED + host + ChatColor.GOLD + messages.get(count)));
                count++;
            }
        }.runTaskTimerAsynchronously(this, 20L, 60*20L);
    }

    @Override
    public boolean onCommand(CommandSender sender, Command cmd, String label, String[] args) {
        if (sender instanceof Player)
        {
            //voegt broadcast toe aan lijst
            if (cmd.getName().equalsIgnoreCase(cmd1))
            {
                message = "";
                for (int i = 1; i < args.length; i++)
                {
                    message = message + args[i] + " ";
                }
                if(args.length > 0)
                {
                    for(int i = 0; i < lengte; i++)
                    {
                        if(args[0].equalsIgnoreCase(messageNames.get(i)))
                        {
                            sender.sendMessage(ChatColor.RED + host + ChatColor.GREEN + "Er bestaat al een broadcast met de naam: " + args[0]);
                            return true;
                        }
                    }
                    sender.sendMessage(ChatColor.RED + host + ChatColor.GREEN + "Broadcast: " + args[0] + " is toegevoegd aan de lijst");
                    messages.add(message);
                    messageNames.add(args[0]);
                    lengte++;
                }
                else
                {
                    sender.sendMessage(ChatColor.RED + host + ChatColor.GREEN + "Uw argumenten kloppen niet");
                }
                return true;
            }

            //removed broadcast van lijst
            if (cmd.getName().equalsIgnoreCase(cmd2))
            {
                String removemessage = args[0];
                for (int i = 0; i < lengte; i++)
                {
                    if (messageNames.get(i).equalsIgnoreCase(removemessage))
                    {
                        messages.remove(i);
                        messageNames.remove(i);
                        sender.sendMessage(ChatColor.RED +  host + ChatColor.GREEN + "Broadcast: " + removemessage + " is verwijderd uit de lijst");
                        lengte--;
                    } else {
                        sender.sendMessage(ChatColor.RED + host + ChatColor.GREEN + "Broadcast: " + removemessage + " is niet gevonden");
                    }
                }
                return true;
            }

            //geeft lijst van broadcasts
            if (cmd.getName().equalsIgnoreCase(cmd3))
            {
                sender.sendMessage(ChatColor.RED + "Broadcasts:");
                for (int i = 0; i < lengte; i++)
                {
                    sender.sendMessage(ChatColor.GREEN + messageNames.get(i));
                }
                return true;
            }

            //voert broadcast uit
            if (cmd.getName().equalsIgnoreCase(cmd4))
            {
                for (int i = 0; i < lengte; i++)
                {
                    if (args[0].equalsIgnoreCase(messageNames.get(i)))
                    {
                        Bukkit.broadcastMessage((ChatColor.RED + host + ChatColor.GOLD + messages.get(i)));
                        return true;
                    }
                }
                sender.sendMessage((ChatColor.RED + host + ChatColor.GREEN + "Broadcast: " + args[0] + " is niet gevonden"));
                return true;
            }
        }
        return false;
    }
}