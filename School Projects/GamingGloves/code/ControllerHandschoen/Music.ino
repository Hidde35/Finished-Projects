// notes in the melody:
int melody[] = {

  NOTE_C4, NOTE_C3, NOTE_C2, NOTE_B1
};

// note durations: 4 = quarter note, 8 = eighth note, etc.:
int noteDurations[] = {

  4, 4, 4, 2
};

void deadMelodie()
{
  if (target == 1)
  {
    for (int i = 0; i < 4; i++) {

      int noteDuration = 1000 / noteDurations[i];

      tone(8, melody[i], noteDuration);

      int pauseBetweenNotes = noteDuration * 1.80;

      delay(pauseBetweenNotes);

      noTone(8);
    }
    target = 0;
  }
}

void bumpWall()
{
  if (target == 2)
  {
    for (int i = 0; i < 1; i++) {

      int noteDuration2 = 1000 / 3;

      tone(8, NOTE_C3, noteDuration2);

      int pauseBetweenNotes2 = noteDuration2 * 1.80;

      delay(pauseBetweenNotes2);

      noTone(8);
    }
    target = 0;
  }
}
