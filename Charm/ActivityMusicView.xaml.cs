﻿using System.Windows.Controls;
using Field;
using Field.General;

namespace Charm;

public partial class ActivityMusicView : UserControl
{
    public ActivityMusicView()
    {
        InitializeComponent();
    }
    
    // Activity only has one music table ever so no taglist
    public void LoadUI(TagHash activityHash)
    {
        TagList.LoadContent(ETagListType.MusicList, activityHash, true);
    }
}