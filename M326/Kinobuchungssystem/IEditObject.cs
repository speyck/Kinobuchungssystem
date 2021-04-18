﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kinobuchungssystem
{
    public interface IEditObject
    {
        StackPanel GetPanel(Cinema cinema = null);

        void EditFromPanel(StackPanel panel);
    }
}
