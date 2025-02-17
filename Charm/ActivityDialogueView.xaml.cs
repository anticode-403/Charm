﻿using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Windows.Controls;
using Field;
using Field.General;

namespace Charm;

public partial class ActivityDialogueView
{
    public ActivityDialogueView()
    {
        InitializeComponent();
    }
    
    public void LoadUI(TagHash tagHash)
    {
        TagList.LoadContent(ETagListType.DialogueList, tagHash, true);
    }
}