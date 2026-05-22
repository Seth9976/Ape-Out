using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppSteamworks
{
	// Token: 0x02000019 RID: 25
	public static class Packsize : Object
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00011498 File Offset: 0x0000F698
		// Note: this type is marked as 'beforefieldinit'.
		static Packsize()
		{
			Il2CppClassPointerStore<Packsize>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "Packsize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Packsize>.NativeClassPtr);
			Packsize.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packsize>.NativeClassPtr, "value");
			Packsize.NativeMethodInfoPtr_Test_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Packsize>.NativeClassPtr, 100663517);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000114F0 File Offset: 0x0000F6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2926, XrefRangeEnd = 2940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Test()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Packsize.NativeMethodInfoPtr_Test_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000282F File Offset: 0x00000A2F
		public Packsize(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00011520 File Offset: 0x0000F720
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002838 File Offset: 0x00000A38
		public unsafe static int value
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Packsize.NativeFieldInfoPtr_value, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Packsize.NativeFieldInfoPtr_value, (void*)(&value));
			}
		}

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Static_Boolean_0;

		// Token: 0x0200023A RID: 570
		[StructLayout(2)]
		public struct ValvePackingSentinel_t
		{
			// Token: 0x06001F97 RID: 8087 RVA: 0x0008B800 File Offset: 0x00089A00
			// Note: this type is marked as 'beforefieldinit'.
			static ValvePackingSentinel_t()
			{
				Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Packsize>.NativeClassPtr, "ValvePackingSentinel_t");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr);
				Packsize.ValvePackingSentinel_t.NativeFieldInfoPtr_m_u32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr, "m_u32");
				Packsize.ValvePackingSentinel_t.NativeFieldInfoPtr_m_u64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr, "m_u64");
				Packsize.ValvePackingSentinel_t.NativeFieldInfoPtr_m_u16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr, "m_u16");
				Packsize.ValvePackingSentinel_t.NativeFieldInfoPtr_m_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr, "m_d");
			}

			// Token: 0x06001F98 RID: 8088 RVA: 0x0000B7DD File Offset: 0x000099DD
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Packsize.ValvePackingSentinel_t>.NativeClassPtr, ref this));
			}

			// Token: 0x04001FD3 RID: 8147
			private static readonly IntPtr NativeFieldInfoPtr_m_u32;

			// Token: 0x04001FD4 RID: 8148
			private static readonly IntPtr NativeFieldInfoPtr_m_u64;

			// Token: 0x04001FD5 RID: 8149
			private static readonly IntPtr NativeFieldInfoPtr_m_u16;

			// Token: 0x04001FD6 RID: 8150
			private static readonly IntPtr NativeFieldInfoPtr_m_d;

			// Token: 0x04001FD7 RID: 8151
			[FieldOffset(0)]
			public uint m_u32;

			// Token: 0x04001FD8 RID: 8152
			[FieldOffset(8)]
			public ulong m_u64;

			// Token: 0x04001FD9 RID: 8153
			[FieldOffset(16)]
			public ushort m_u16;

			// Token: 0x04001FDA RID: 8154
			[FieldOffset(24)]
			public double m_d;
		}
	}
}
