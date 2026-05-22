using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200004E RID: 78
	public static class SECTR_Modules : Object
	{
		// Token: 0x06000BAD RID: 2989 RVA: 0x00056DE8 File Offset: 0x00054FE8
		// Note: this type is marked as 'beforefieldinit'.
		static SECTR_Modules()
		{
			Il2CppClassPointerStore<SECTR_Modules>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SECTR_Modules");
			SECTR_Modules.NativeFieldInfoPtr_AUDIO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Modules>.NativeClassPtr, "AUDIO");
			SECTR_Modules.NativeFieldInfoPtr_VIS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Modules>.NativeClassPtr, "VIS");
			SECTR_Modules.NativeFieldInfoPtr_STREAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Modules>.NativeClassPtr, "STREAM");
			SECTR_Modules.NativeFieldInfoPtr_DEV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Modules>.NativeClassPtr, "DEV");
			SECTR_Modules.NativeFieldInfoPtr_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SECTR_Modules>.NativeClassPtr, "VERSION");
			SECTR_Modules.NativeMethodInfoPtr_HasPro_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Modules>.NativeClassPtr, 100664291);
			SECTR_Modules.NativeMethodInfoPtr_HasComplete_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SECTR_Modules>.NativeClassPtr, 100664292);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00056E9C File Offset: 0x0005509C
		[CallerCount(0)]
		public unsafe static bool HasPro()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Modules.NativeMethodInfoPtr_HasPro_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00056ECC File Offset: 0x000550CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41975, XrefRangeEnd = 41983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasComplete()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SECTR_Modules.NativeMethodInfoPtr_HasComplete_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0000938B File Offset: 0x0000758B
		public SECTR_Modules(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00056EFC File Offset: 0x000550FC
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x00009394 File Offset: 0x00007594
		public unsafe static bool AUDIO
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Modules.NativeFieldInfoPtr_AUDIO, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Modules.NativeFieldInfoPtr_AUDIO, (void*)(&value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00056F18 File Offset: 0x00055118
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x000093A2 File Offset: 0x000075A2
		public unsafe static bool VIS
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Modules.NativeFieldInfoPtr_VIS, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Modules.NativeFieldInfoPtr_VIS, (void*)(&value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x00056F34 File Offset: 0x00055134
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x000093B0 File Offset: 0x000075B0
		public unsafe static bool STREAM
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Modules.NativeFieldInfoPtr_STREAM, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Modules.NativeFieldInfoPtr_STREAM, (void*)(&value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x00056F50 File Offset: 0x00055150
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x000093BE File Offset: 0x000075BE
		public unsafe static bool DEV
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Modules.NativeFieldInfoPtr_DEV, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Modules.NativeFieldInfoPtr_DEV, (void*)(&value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x00056F6C File Offset: 0x0005516C
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x000093CC File Offset: 0x000075CC
		public unsafe static string VERSION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SECTR_Modules.NativeFieldInfoPtr_VERSION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SECTR_Modules.NativeFieldInfoPtr_VERSION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_AUDIO;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_VIS;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_STREAM;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_DEV;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_VERSION;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_HasPro_Public_Static_Boolean_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_HasComplete_Public_Static_Boolean_0;
	}
}
