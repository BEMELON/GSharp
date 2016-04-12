﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GSharp.Graphic.Core;
using GSharp.Graphic.Holes;
using GSharp.Base.Cores;
using GSharp.Base.Objects;
using GSharp.Extension;

namespace GSharp.Graphic.Objects
{
    /// <summary>
    /// VariableBlock.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PropertyBlock : ObjectBlock
    {
        private GProperty GProperty;

        // 생성자
        public PropertyBlock(GCommand command)
        {
            InitializeComponent();

            GProperty = new GProperty(command);

            PropertyName.Text = command.FriendlyName;
        }

        public override GObject GObject
        {
            get
            {
                return GProperty;
            }
        }

        public override List<GBase> GObjectList
        {
            get
            {
                return new List<GBase> { GObject };
            }
        }
    }
}
