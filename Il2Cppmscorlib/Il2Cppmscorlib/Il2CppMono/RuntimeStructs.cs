using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x0200000D RID: 13
	public static class RuntimeStructs : Object
	{
		// Token: 0x06000045 RID: 69 RVA: 0x000020F7 File Offset: 0x000002F7
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeStructs()
		{
			Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeStructs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000211C File Offset: 0x0000031C
		public RuntimeStructs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x02000531 RID: 1329
		[StructLayout(2)]
		public struct RemoteClass
		{
			// Token: 0x06004EE8 RID: 20200 RVA: 0x0016745C File Offset: 0x0016565C
			// Note: this type is marked as 'beforefieldinit'.
			static RemoteClass()
			{
				Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "RemoteClass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr);
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_default_vtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "default_vtable");
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_xdomain_vtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "xdomain_vtable");
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_proxy_class = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "proxy_class");
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_proxy_class_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "proxy_class_name");
				RuntimeStructs.RemoteClass.NativeFieldInfoPtr_interface_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, "interface_count");
			}

			// Token: 0x06004EE9 RID: 20201 RVA: 0x0001D8B5 File Offset: 0x0001BAB5
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.RemoteClass>.NativeClassPtr, ref this));
			}

			// Token: 0x04003F79 RID: 16249
			private static readonly IntPtr NativeFieldInfoPtr_default_vtable;

			// Token: 0x04003F7A RID: 16250
			private static readonly IntPtr NativeFieldInfoPtr_xdomain_vtable;

			// Token: 0x04003F7B RID: 16251
			private static readonly IntPtr NativeFieldInfoPtr_proxy_class;

			// Token: 0x04003F7C RID: 16252
			private static readonly IntPtr NativeFieldInfoPtr_proxy_class_name;

			// Token: 0x04003F7D RID: 16253
			private static readonly IntPtr NativeFieldInfoPtr_interface_count;

			// Token: 0x04003F7E RID: 16254
			[FieldOffset(0)]
			public IntPtr default_vtable;

			// Token: 0x04003F7F RID: 16255
			[FieldOffset(8)]
			public IntPtr xdomain_vtable;

			// Token: 0x04003F80 RID: 16256
			[FieldOffset(16)]
			public IntPtr proxy_class;

			// Token: 0x04003F81 RID: 16257
			[FieldOffset(24)]
			public IntPtr proxy_class_name;

			// Token: 0x04003F82 RID: 16258
			[FieldOffset(32)]
			public uint interface_count;
		}

		// Token: 0x02000532 RID: 1330
		[StructLayout(2)]
		public struct MonoClass
		{
			// Token: 0x06004EEA RID: 20202 RVA: 0x0001D8C7 File Offset: 0x0001BAC7
			// Note: this type is marked as 'beforefieldinit'.
			static MonoClass()
			{
				Il2CppClassPointerStore<RuntimeStructs.MonoClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "MonoClass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.MonoClass>.NativeClassPtr);
			}

			// Token: 0x06004EEB RID: 20203 RVA: 0x0001D8E7 File Offset: 0x0001BAE7
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.MonoClass>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000533 RID: 1331
		[StructLayout(2)]
		public struct GenericParamInfo
		{
			// Token: 0x06004EEC RID: 20204 RVA: 0x001674EC File Offset: 0x001656EC
			// Note: this type is marked as 'beforefieldinit'.
			static GenericParamInfo()
			{
				Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "GenericParamInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr);
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_pklass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "pklass");
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "name");
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "flags");
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "token");
				RuntimeStructs.GenericParamInfo.NativeFieldInfoPtr_constraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, "constraints");
			}

			// Token: 0x06004EED RID: 20205 RVA: 0x0001D8F9 File Offset: 0x0001BAF9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.GenericParamInfo>.NativeClassPtr, ref this));
			}

			// Token: 0x04003F83 RID: 16259
			private static readonly IntPtr NativeFieldInfoPtr_pklass;

			// Token: 0x04003F84 RID: 16260
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04003F85 RID: 16261
			private static readonly IntPtr NativeFieldInfoPtr_flags;

			// Token: 0x04003F86 RID: 16262
			private static readonly IntPtr NativeFieldInfoPtr_token;

			// Token: 0x04003F87 RID: 16263
			private static readonly IntPtr NativeFieldInfoPtr_constraints;

			// Token: 0x04003F88 RID: 16264
			[FieldOffset(0)]
			public IntPtr pklass;

			// Token: 0x04003F89 RID: 16265
			[FieldOffset(8)]
			public IntPtr name;

			// Token: 0x04003F8A RID: 16266
			[FieldOffset(16)]
			public ushort flags;

			// Token: 0x04003F8B RID: 16267
			[FieldOffset(20)]
			public uint token;

			// Token: 0x04003F8C RID: 16268
			[FieldOffset(24)]
			public IntPtr constraints;
		}

		// Token: 0x02000534 RID: 1332
		[StructLayout(2)]
		public struct GPtrArray
		{
			// Token: 0x06004EEE RID: 20206 RVA: 0x0016757C File Offset: 0x0016577C
			// Note: this type is marked as 'beforefieldinit'.
			static GPtrArray()
			{
				Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "GPtrArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr);
				RuntimeStructs.GPtrArray.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr, "data");
				RuntimeStructs.GPtrArray.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr, "len");
			}

			// Token: 0x06004EEF RID: 20207 RVA: 0x0001D90B File Offset: 0x0001BB0B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.GPtrArray>.NativeClassPtr, ref this));
			}

			// Token: 0x04003F8D RID: 16269
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04003F8E RID: 16270
			private static readonly IntPtr NativeFieldInfoPtr_len;

			// Token: 0x04003F8F RID: 16271
			[FieldOffset(0)]
			public IntPtr data;

			// Token: 0x04003F90 RID: 16272
			[FieldOffset(8)]
			public int len;
		}

		// Token: 0x02000535 RID: 1333
		[StructLayout(2)]
		public struct HandleStackMark
		{
			// Token: 0x06004EF0 RID: 20208 RVA: 0x001675D0 File Offset: 0x001657D0
			// Note: this type is marked as 'beforefieldinit'.
			static HandleStackMark()
			{
				Il2CppClassPointerStore<RuntimeStructs.HandleStackMark>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "HandleStackMark");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.HandleStackMark>.NativeClassPtr);
				RuntimeStructs.HandleStackMark.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.HandleStackMark>.NativeClassPtr, "size");
				RuntimeStructs.HandleStackMark.NativeFieldInfoPtr_interior_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.HandleStackMark>.NativeClassPtr, "interior_size");
				RuntimeStructs.HandleStackMark.NativeFieldInfoPtr_chunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.HandleStackMark>.NativeClassPtr, "chunk");
			}

			// Token: 0x06004EF1 RID: 20209 RVA: 0x0001D91D File Offset: 0x0001BB1D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.HandleStackMark>.NativeClassPtr, ref this));
			}

			// Token: 0x04003F91 RID: 16273
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04003F92 RID: 16274
			private static readonly IntPtr NativeFieldInfoPtr_interior_size;

			// Token: 0x04003F93 RID: 16275
			private static readonly IntPtr NativeFieldInfoPtr_chunk;

			// Token: 0x04003F94 RID: 16276
			[FieldOffset(0)]
			public int size;

			// Token: 0x04003F95 RID: 16277
			[FieldOffset(4)]
			public int interior_size;

			// Token: 0x04003F96 RID: 16278
			[FieldOffset(8)]
			public IntPtr chunk;
		}

		// Token: 0x02000536 RID: 1334
		[StructLayout(2)]
		public struct MonoError
		{
			// Token: 0x06004EF2 RID: 20210 RVA: 0x00167638 File Offset: 0x00165838
			// Note: this type is marked as 'beforefieldinit'.
			static MonoError()
			{
				Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "MonoError");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr);
				RuntimeStructs.MonoError.NativeFieldInfoPtr_error_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "error_code");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_0");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_1");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_2");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_3");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_4");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_5");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_6");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_7");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_8");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_11");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_12");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_13");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_14");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_15");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_16");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_17");
				RuntimeStructs.MonoError.NativeFieldInfoPtr_hidden_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, "hidden_18");
			}

			// Token: 0x06004EF3 RID: 20211 RVA: 0x0001D92F File Offset: 0x0001BB2F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeStructs.MonoError>.NativeClassPtr, ref this));
			}

			// Token: 0x04003F97 RID: 16279
			private static readonly IntPtr NativeFieldInfoPtr_error_code;

			// Token: 0x04003F98 RID: 16280
			private static readonly IntPtr NativeFieldInfoPtr_hidden_0;

			// Token: 0x04003F99 RID: 16281
			private static readonly IntPtr NativeFieldInfoPtr_hidden_1;

			// Token: 0x04003F9A RID: 16282
			private static readonly IntPtr NativeFieldInfoPtr_hidden_2;

			// Token: 0x04003F9B RID: 16283
			private static readonly IntPtr NativeFieldInfoPtr_hidden_3;

			// Token: 0x04003F9C RID: 16284
			private static readonly IntPtr NativeFieldInfoPtr_hidden_4;

			// Token: 0x04003F9D RID: 16285
			private static readonly IntPtr NativeFieldInfoPtr_hidden_5;

			// Token: 0x04003F9E RID: 16286
			private static readonly IntPtr NativeFieldInfoPtr_hidden_6;

			// Token: 0x04003F9F RID: 16287
			private static readonly IntPtr NativeFieldInfoPtr_hidden_7;

			// Token: 0x04003FA0 RID: 16288
			private static readonly IntPtr NativeFieldInfoPtr_hidden_8;

			// Token: 0x04003FA1 RID: 16289
			private static readonly IntPtr NativeFieldInfoPtr_hidden_11;

			// Token: 0x04003FA2 RID: 16290
			private static readonly IntPtr NativeFieldInfoPtr_hidden_12;

			// Token: 0x04003FA3 RID: 16291
			private static readonly IntPtr NativeFieldInfoPtr_hidden_13;

			// Token: 0x04003FA4 RID: 16292
			private static readonly IntPtr NativeFieldInfoPtr_hidden_14;

			// Token: 0x04003FA5 RID: 16293
			private static readonly IntPtr NativeFieldInfoPtr_hidden_15;

			// Token: 0x04003FA6 RID: 16294
			private static readonly IntPtr NativeFieldInfoPtr_hidden_16;

			// Token: 0x04003FA7 RID: 16295
			private static readonly IntPtr NativeFieldInfoPtr_hidden_17;

			// Token: 0x04003FA8 RID: 16296
			private static readonly IntPtr NativeFieldInfoPtr_hidden_18;

			// Token: 0x04003FA9 RID: 16297
			[FieldOffset(0)]
			public ushort error_code;

			// Token: 0x04003FAA RID: 16298
			[FieldOffset(2)]
			public ushort hidden_0;

			// Token: 0x04003FAB RID: 16299
			[FieldOffset(8)]
			public IntPtr hidden_1;

			// Token: 0x04003FAC RID: 16300
			[FieldOffset(16)]
			public IntPtr hidden_2;

			// Token: 0x04003FAD RID: 16301
			[FieldOffset(24)]
			public IntPtr hidden_3;

			// Token: 0x04003FAE RID: 16302
			[FieldOffset(32)]
			public IntPtr hidden_4;

			// Token: 0x04003FAF RID: 16303
			[FieldOffset(40)]
			public IntPtr hidden_5;

			// Token: 0x04003FB0 RID: 16304
			[FieldOffset(48)]
			public IntPtr hidden_6;

			// Token: 0x04003FB1 RID: 16305
			[FieldOffset(56)]
			public IntPtr hidden_7;

			// Token: 0x04003FB2 RID: 16306
			[FieldOffset(64)]
			public IntPtr hidden_8;

			// Token: 0x04003FB3 RID: 16307
			[FieldOffset(72)]
			public IntPtr hidden_11;

			// Token: 0x04003FB4 RID: 16308
			[FieldOffset(80)]
			public IntPtr hidden_12;

			// Token: 0x04003FB5 RID: 16309
			[FieldOffset(88)]
			public IntPtr hidden_13;

			// Token: 0x04003FB6 RID: 16310
			[FieldOffset(96)]
			public IntPtr hidden_14;

			// Token: 0x04003FB7 RID: 16311
			[FieldOffset(104)]
			public IntPtr hidden_15;

			// Token: 0x04003FB8 RID: 16312
			[FieldOffset(112)]
			public IntPtr hidden_16;

			// Token: 0x04003FB9 RID: 16313
			[FieldOffset(120)]
			public IntPtr hidden_17;

			// Token: 0x04003FBA RID: 16314
			[FieldOffset(128)]
			public IntPtr hidden_18;
		}
	}
}
