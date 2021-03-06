﻿using BashSoft;
using System;
using System.Collections.Generic;
using System.Linq;

public class RepositorySorter
{
    public void OrderAndTake(Dictionary<string, double> studentsMarks, string comparison, int studentsToTake)
    {
        comparison = comparison.ToLower();
        if (comparison == "ascending")
        {
            this.PrintStudents(studentsMarks
                .OrderBy(x => x.Value)
                .Take(studentsToTake)
                .ToDictionary(pair => pair.Key, pair => pair.Value)); 
        }
        else if (comparison == "descending")
        {
            PrintStudents(studentsMarks
                .OrderByDescending(x => x.Value)
                .Take(studentsToTake)
                .ToDictionary(pair => pair.Key, pair => pair.Value));
        }
        else
        {
            throw new InvalidOperationException(ExceptionMessages.InvalidComparisonQuery);
        }
    }

    private void PrintStudents(Dictionary<string, double> studentsSorted)
    {
        foreach (var student in studentsSorted)
        {
                OutputWriter.PrintStudent(new KeyValuePair<string, double>(student.Key, student.Value)); //?
        }
    }
}



