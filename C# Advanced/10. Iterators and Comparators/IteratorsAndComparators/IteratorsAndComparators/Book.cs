﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IteratorsAndComparators
{
    public class Book: IComparable<Book>
    {
        public int Year { get; set; }
        public string Title { get; set; }
        public IReadOnlyList<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            Year = year;
            Title = title;
            Authors = authors;
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }

        public int CompareTo(Book other)
        {
            int result = Year.CompareTo(other.Year);
            if (result==0)
            {
                return Title.CompareTo(other.Title);
            }
            return result;
        }

        
    }
}