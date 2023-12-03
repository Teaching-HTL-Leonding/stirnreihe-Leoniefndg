using System;
using System.Collections.Generic;

namespace StirnReihe.Logic
{
	public class LineOfPeople
	{
       public Node? First { get; set; }

        public void AddToFront(Person person)
        {
            var node = new Node();
            //person in node gespeichert
            node.Person = person;
            //Zeichnung goodnotes seite 7
            node.Next = First;
            First = node;
        }
       public void clear()
        {
            First = null;
        }
       public void AddSortetd(Person person)
        {

        }
    }

  
}

