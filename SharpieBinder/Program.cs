﻿using System;
using System.Collections.Generic;
using Clang.Ast;
using System.IO;

namespace SharpieBinder
{
	
	class MainClass
	{
		const string output = "/cvs/urho/bindings/generated";

		public static int Main (string[] args)
		{
			Directory.CreateDirectory (output);
			Console.WriteLine("This needs a 64-bit Mono to run, and libclang-mono.dylib in /usr/lib");
			if (args.Length == 0) {
				//Console.Error.WriteLine ("error: provide a PCH file to dump");
				//return 1;
				args = new String[] { "/Users/miguel/Dropbox/UrhoBindings/test.pch" };
			}

			var reader = new AstReader ();
			var binder = new CxxBinder();
			reader.TranslationUnitParsed += tu => tu.Accept (binder);
			reader.Load (args [0]);
			foreach (var st in binder.Generate()) {
				File.WriteAllText (output + "/" + st.FileName, st.ToString ());
				//File.WriteAllText (output + "/" + st.FileName + ".c"
			}
			Console.WriteLine($"Dumped data into {output}");
			
			return 0;
		}
	}
}