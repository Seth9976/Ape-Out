using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppI2.Loc
{
	// Token: 0x02000271 RID: 625
	public static class ScriptTerms : Object
	{
		// Token: 0x060046B2 RID: 18098 RVA: 0x00107BB4 File Offset: 0x00105DB4
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptTerms()
		{
			Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "I2.Loc", "ScriptTerms");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr);
			ScriptTerms.NativeFieldInfoPtr_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr, "ON");
			ScriptTerms.NativeFieldInfoPtr_OFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr, "OFF");
			ScriptTerms.NativeFieldInfoPtr_WINDOWED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr, "WINDOWED");
			ScriptTerms.NativeFieldInfoPtr_EXCLUSIVE_FULLSCREEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr, "EXCLUSIVE_FULLSCREEN");
			ScriptTerms.NativeFieldInfoPtr_FULLSCREEN_WINDOW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr, "FULLSCREEN_WINDOW");
			ScriptTerms.NativeFieldInfoPtr_LOADING_SCORES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr, "LOADING_SCORES");
			ScriptTerms.NativeFieldInfoPtr_FAILED_TO_CONNECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr, "FAILED_TO_CONNECT");
			ScriptTerms.NativeFieldInfoPtr_PRESS_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr, "PRESS_KEY");
			ScriptTerms.NativeFieldInfoPtr_SCORE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr, "SCORE");
			ScriptTerms.NativeFieldInfoPtr_HIGH_SCORE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr, "HIGH_SCORE");
			ScriptTerms.NativeFieldInfoPtr_NEW_HIGH_SCORE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr, "NEW_HIGH_SCORE");
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x00029F56 File Offset: 0x00028156
		public ScriptTerms(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x00107CC0 File Offset: 0x00105EC0
		// (set) Token: 0x060046B5 RID: 18101 RVA: 0x00029F5F File Offset: 0x0002815F
		public unsafe static string ON
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptTerms.NativeFieldInfoPtr_ON, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptTerms.NativeFieldInfoPtr_ON, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x060046B6 RID: 18102 RVA: 0x00107CE0 File Offset: 0x00105EE0
		// (set) Token: 0x060046B7 RID: 18103 RVA: 0x00029F71 File Offset: 0x00028171
		public unsafe static string OFF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptTerms.NativeFieldInfoPtr_OFF, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptTerms.NativeFieldInfoPtr_OFF, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x00107D00 File Offset: 0x00105F00
		// (set) Token: 0x060046B9 RID: 18105 RVA: 0x00029F83 File Offset: 0x00028183
		public unsafe static string WINDOWED
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptTerms.NativeFieldInfoPtr_WINDOWED, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptTerms.NativeFieldInfoPtr_WINDOWED, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x00107D20 File Offset: 0x00105F20
		// (set) Token: 0x060046BB RID: 18107 RVA: 0x00029F95 File Offset: 0x00028195
		public unsafe static string EXCLUSIVE_FULLSCREEN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptTerms.NativeFieldInfoPtr_EXCLUSIVE_FULLSCREEN, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptTerms.NativeFieldInfoPtr_EXCLUSIVE_FULLSCREEN, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x00107D40 File Offset: 0x00105F40
		// (set) Token: 0x060046BD RID: 18109 RVA: 0x00029FA7 File Offset: 0x000281A7
		public unsafe static string FULLSCREEN_WINDOW
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptTerms.NativeFieldInfoPtr_FULLSCREEN_WINDOW, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptTerms.NativeFieldInfoPtr_FULLSCREEN_WINDOW, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x00107D60 File Offset: 0x00105F60
		// (set) Token: 0x060046BF RID: 18111 RVA: 0x00029FB9 File Offset: 0x000281B9
		public unsafe static string LOADING_SCORES
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptTerms.NativeFieldInfoPtr_LOADING_SCORES, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptTerms.NativeFieldInfoPtr_LOADING_SCORES, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x060046C0 RID: 18112 RVA: 0x00107D80 File Offset: 0x00105F80
		// (set) Token: 0x060046C1 RID: 18113 RVA: 0x00029FCB File Offset: 0x000281CB
		public unsafe static string FAILED_TO_CONNECT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptTerms.NativeFieldInfoPtr_FAILED_TO_CONNECT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptTerms.NativeFieldInfoPtr_FAILED_TO_CONNECT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x060046C2 RID: 18114 RVA: 0x00107DA0 File Offset: 0x00105FA0
		// (set) Token: 0x060046C3 RID: 18115 RVA: 0x00029FDD File Offset: 0x000281DD
		public unsafe static string PRESS_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptTerms.NativeFieldInfoPtr_PRESS_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptTerms.NativeFieldInfoPtr_PRESS_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x060046C4 RID: 18116 RVA: 0x00107DC0 File Offset: 0x00105FC0
		// (set) Token: 0x060046C5 RID: 18117 RVA: 0x00029FEF File Offset: 0x000281EF
		public unsafe static string SCORE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptTerms.NativeFieldInfoPtr_SCORE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptTerms.NativeFieldInfoPtr_SCORE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x060046C6 RID: 18118 RVA: 0x00107DE0 File Offset: 0x00105FE0
		// (set) Token: 0x060046C7 RID: 18119 RVA: 0x0002A001 File Offset: 0x00028201
		public unsafe static string HIGH_SCORE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptTerms.NativeFieldInfoPtr_HIGH_SCORE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptTerms.NativeFieldInfoPtr_HIGH_SCORE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x060046C8 RID: 18120 RVA: 0x00107E00 File Offset: 0x00106000
		// (set) Token: 0x060046C9 RID: 18121 RVA: 0x0002A013 File Offset: 0x00028213
		public unsafe static string NEW_HIGH_SCORE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptTerms.NativeFieldInfoPtr_NEW_HIGH_SCORE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptTerms.NativeFieldInfoPtr_NEW_HIGH_SCORE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002C3C RID: 11324
		private static readonly IntPtr NativeFieldInfoPtr_ON;

		// Token: 0x04002C3D RID: 11325
		private static readonly IntPtr NativeFieldInfoPtr_OFF;

		// Token: 0x04002C3E RID: 11326
		private static readonly IntPtr NativeFieldInfoPtr_WINDOWED;

		// Token: 0x04002C3F RID: 11327
		private static readonly IntPtr NativeFieldInfoPtr_EXCLUSIVE_FULLSCREEN;

		// Token: 0x04002C40 RID: 11328
		private static readonly IntPtr NativeFieldInfoPtr_FULLSCREEN_WINDOW;

		// Token: 0x04002C41 RID: 11329
		private static readonly IntPtr NativeFieldInfoPtr_LOADING_SCORES;

		// Token: 0x04002C42 RID: 11330
		private static readonly IntPtr NativeFieldInfoPtr_FAILED_TO_CONNECT;

		// Token: 0x04002C43 RID: 11331
		private static readonly IntPtr NativeFieldInfoPtr_PRESS_KEY;

		// Token: 0x04002C44 RID: 11332
		private static readonly IntPtr NativeFieldInfoPtr_SCORE;

		// Token: 0x04002C45 RID: 11333
		private static readonly IntPtr NativeFieldInfoPtr_HIGH_SCORE;

		// Token: 0x04002C46 RID: 11334
		private static readonly IntPtr NativeFieldInfoPtr_NEW_HIGH_SCORE;

		// Token: 0x020003E0 RID: 992
		public static class Menu : Object
		{
			// Token: 0x06005AA1 RID: 23201 RVA: 0x001474D0 File Offset: 0x001456D0
			// Note: this type is marked as 'beforefieldinit'.
			static Menu()
			{
				Il2CppClassPointerStore<ScriptTerms.Menu>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptTerms>.NativeClassPtr, "Menu");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptTerms.Menu>.NativeClassPtr);
				ScriptTerms.Menu.NativeFieldInfoPtr_HARDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptTerms.Menu>.NativeClassPtr, "HARDER");
				ScriptTerms.Menu.NativeFieldInfoPtr_SOFTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptTerms.Menu>.NativeClassPtr, "SOFTER");
			}

			// Token: 0x06005AA2 RID: 23202 RVA: 0x00033C02 File Offset: 0x00031E02
			public Menu(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170020FB RID: 8443
			// (get) Token: 0x06005AA3 RID: 23203 RVA: 0x00147524 File Offset: 0x00145724
			// (set) Token: 0x06005AA4 RID: 23204 RVA: 0x00033C0B File Offset: 0x00031E0B
			public unsafe static string HARDER
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptTerms.Menu.NativeFieldInfoPtr_HARDER, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptTerms.Menu.NativeFieldInfoPtr_HARDER, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170020FC RID: 8444
			// (get) Token: 0x06005AA5 RID: 23205 RVA: 0x00147544 File Offset: 0x00145744
			// (set) Token: 0x06005AA6 RID: 23206 RVA: 0x00033C1D File Offset: 0x00031E1D
			public unsafe static string SOFTER
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScriptTerms.Menu.NativeFieldInfoPtr_SOFTER, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScriptTerms.Menu.NativeFieldInfoPtr_SOFTER, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003C2F RID: 15407
			private static readonly IntPtr NativeFieldInfoPtr_HARDER;

			// Token: 0x04003C30 RID: 15408
			private static readonly IntPtr NativeFieldInfoPtr_SOFTER;
		}
	}
}
