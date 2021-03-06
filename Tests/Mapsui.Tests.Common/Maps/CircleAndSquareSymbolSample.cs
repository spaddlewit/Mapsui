﻿using System.Collections.Generic;
using Mapsui.Geometries;
using Mapsui.Layers;
using Mapsui.Providers;
using Mapsui.Styles;

namespace Mapsui.Tests.Common.Maps
{
    public static class CircleAndSquareSymbolSample
    {
        public static Map CreateMap()
        {
            var map = new Map
            {
                BackColor = Color.Transparent,
                Viewport =
                {
                    Center = new Point(0, 0),
                    Width = 200,
                    Height = 200,
                    Resolution = 0.5
                }
            };
            map.Layers.Add(new MemoryLayer
            {
                DataSource = new MemoryProvider(CreateFeatures()),
                Name = "Circle and square symbols"
            });
            return map;
        }

        private static Features CreateFeatures()
        {
            return new Features
            {
                new Feature
                {
                    Geometry = new Point(-20, 0),
                    Styles = new List<IStyle>
                    {
                        new SymbolStyle
                        {
                            Fill = new Brush {Color = Color.Gray},
                            Outline = new Pen(Color.Black),
                            SymbolType = SymbolType.Ellipse
                        }
                    }
                },
                new Feature
                {
                    Geometry = new Point(20, 0),
                    Styles = new List<IStyle>
                    {
                        new SymbolStyle
                        {
                            Fill = new Brush {Color = Color.Gray},
                            Outline = new Pen(Color.Black),
                            SymbolType = SymbolType.Rectangle
                        }
                    }
                }
            };
        }
    }
}