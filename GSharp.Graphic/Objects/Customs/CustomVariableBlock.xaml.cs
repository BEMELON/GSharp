﻿using System.Collections.Generic;
using GSharp.Graphic.Blocks;
using GSharp.Graphic.Holes;
using GSharp.Base.Cores;
using GSharp.Base.Objects;
using System;
using System.Windows.Media;
using GSharp.Base.Objects.Customs;

namespace GSharp.Graphic.Objects.Customs
{
    /// <summary>
    /// NumberBlock.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CustomVariableBlock : CustomBlock, IVariableBlock
    {
        public override GCustom GCustom
        {
            get
            {
                return GCustomVariable;
            }
        }

        public override GObject GObject
        {
            get
            {
                return GCustomVariable;
            }
        }

        public IVariable IVariable
        {
            get
            {
                return GCustomVariable;
            }
        }

        public GCustomVariable GCustomVariable
        {
            get
            {
                return _GCustomVariable;
            }
        }
        private GCustomVariable _GCustomVariable;

        public override List<GBase> ToGObjectList()
        {
            return _GObjectList;
        }
        private List<GBase> _GObjectList;

        public CustomVariableBlock(GCustomVariable variable)
            : base(variable.CustomType)
        {
            InitializeComponent();

            _GCustomVariable = variable;
            _GObjectList = new List<GBase>() { GObject };

            // Set background color
            Background = new SolidColorBrush(GetColor(Type));

            VariableName.Text = variable.Name;

            // Init block
            InitializeBlock();
        }
    }
}