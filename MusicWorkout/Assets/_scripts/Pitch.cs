using System;
using System.Collections;


[Serializable]
public class Pitch
{

    #region Enums definition

    /// <summary>
    /// The step type represents a step of the diatonic scale, represented using the English letters A through G.
    /// yum_comment: I define it as enum based in diatonic C major scale, and with first C starting at 1.
    /// </summary>
    public enum Step
    {
        C = 1,
        D,
        E,
        F,
        G,
        A,
        B
    }

    /// <summary>
    /// The semitones type is a number representing semitones, used for chromatic alteration. 
    /// A value of -1 corresponds to a flat and a value of 1 to a sharp. 
    /// yum_comment: I define it as enum versus MusicXML decimal, couse i didn't plan to use microtones in scores.
    /// </summary>
    public enum Semitones
    {
        flat = -1,
        natural,
        sharp
    }

    /// <summary>
    /// Octaves are represented by the numbers 0 to 9, where 4 indicates the octave started by middle C.
    /// </summary>
    public enum Octave
    {
        subContra = 0,
        contra,
        great,
        small,
        first,
        second,
        third,
        fourth,
        five
    }


    #endregion

    public Step step;
    public Semitones alter;
    public Octave octave;

    public Pitch()
    {
        step = Step.C;
        alter = Semitones.natural;
        octave = Octave.first;
    }

    public Pitch(Step setStep, Semitones setAlter, Octave setOctave)
    {
        step = setStep;
        alter = setAlter;
        octave = setOctave;
    }

    public string ToString(bool numericOutput)
    {
        if (numericOutput == true)
        {
            string alteration = "";
            if ((int)alter == -1)
            {
                alteration = "b";
            }
            else if((int)alter == 1)
            {
                alteration = "#";
            }
            return step.ToString() + alteration + ((int)octave).ToString();
        }
        else
        {
            return step.ToString() + alter.ToString() + octave.ToString();
        }        
    }
}
