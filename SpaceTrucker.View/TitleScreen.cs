﻿using System;

namespace SpaceTrucker.View
{
	class TitleScreen : IViewScreen
	{
		public ViewMode ModeType => ViewMode.TitleScreen;

		private Coord origin;

		private string[] title = new string[]
		{
			@"  *                                                                                           *   ",
			@"                      *                                                                           ",
			@"                                                                                                  ",
			@"                                                      *                                           ",
			@"                                                                                                  ",
			@"                                                                                                  ",
			@"         *                                                           *                            ",
			@" ____                                        ______                       __            *         ",
			@"/\  _`\                 *                   /\__  _\                     /\ \                     ",
			@"\ \,\\_\   _____      __      ___     __    \/_/\ \/ _ __   __  __    ___\ \ \/'\      __   _ __  ",
			@" \/_\__ \ /\ '__`\  /'__`\   /'___\ /'__`\     \ \ \/\`'__\/\ \/\ \  /'___\ \ , <    /'__`\/\`'__\",
			@"   /\ \L\ \ \ \L\ \/\ \L\.\_/\ \__//\  __/      \ \ \ \ \/ \ \ \_\ \/\ \__/\ \ \\`\ /\  __/\ \ \/ ",
			@"   \ `\____\ \ ,__/\ \__/.\_\ \____\ \____\      \ \_\ \_\  \ \____/\ \____\\ \_\ \_\ \____\\ \_\ ",
			@"    \/_____/\ \ \/  \/__/\/_/\/____/\/____/       \/_/\/_/   \/___/  \/____/ \/_/\/_/\/____/ \/_/ ",
			@"             \ \_\                                                                                ",
			@"              \/_/                           *                                                    ",
			@"     *                                                                           *                ",
			@"                                  *                                                               ",
			@"                                                                      *                           ",
			@"                                                                                                  ",
			@"                *                                                                                 ",
			@"                                                                                                  ",
			@"                                                         *                                        ",
			@"                                                                                           *      ",
			@"                                                                         *                        ",
			@" *                            *                                                                   ",
		};

		public void CompleteRefresh(Coord shipConsoleOrigin)
		{
			int offsetX = 6;
			int offsetY = 18;
			origin = new Coord(shipConsoleOrigin.X + offsetX, shipConsoleOrigin.Y - offsetY);

			PrintTitle();
		}

		private void PrintTitle()
		{
			Console.ForegroundColor = Write.ColorDefaultFG;
			Console.BackgroundColor = Write.ColorDisplayBG;

			for (int i = 0; i < title.Length; i++)
			{
				Console.SetCursorPosition(origin.X, origin.Y - 27 + i);
				Console.Write(title[i]);
			}
		}
	}
}