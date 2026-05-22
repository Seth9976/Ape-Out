using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSteamworks
{
	// Token: 0x02000016 RID: 22
	public class InteropHelp : Object
	{
		// Token: 0x060000FB RID: 251 RVA: 0x000110A4 File Offset: 0x0000F2A4
		// Note: this type is marked as 'beforefieldinit'.
		static InteropHelp()
		{
			Il2CppClassPointerStore<InteropHelp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "InteropHelp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr);
			InteropHelp.NativeMethodInfoPtr_TestIfPlatformSupported_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100663502);
			InteropHelp.NativeMethodInfoPtr_TestIfAvailableClient_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100663503);
			InteropHelp.NativeMethodInfoPtr_TestIfAvailableGameServer_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100663504);
			InteropHelp.NativeMethodInfoPtr_PtrToStringUTF8_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100663505);
			InteropHelp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, 100663506);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00011138 File Offset: 0x0000F338
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestIfPlatformSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.NativeMethodInfoPtr_TestIfPlatformSupported_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00011160 File Offset: 0x0000F360
		[CallerCount(635)]
		[CachedScanResults(RefRangeStart = 1851, RefRangeEnd = 2486, XrefRangeStart = 1847, XrefRangeEnd = 1851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestIfAvailableClient()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.NativeMethodInfoPtr_TestIfAvailableClient_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00011188 File Offset: 0x0000F388
		[CallerCount(299)]
		[CachedScanResults(RefRangeStart = 2490, RefRangeEnd = 2789, XrefRangeStart = 2486, XrefRangeEnd = 2490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestIfAvailableGameServer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.NativeMethodInfoPtr_TestIfAvailableGameServer_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000111B0 File Offset: 0x0000F3B0
		[CallerCount(67)]
		[CachedScanResults(RefRangeStart = 2808, RefRangeEnd = 2875, XrefRangeStart = 2789, XrefRangeEnd = 2808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PtrToStringUTF8(IntPtr nativeUtf8)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeUtf8;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.NativeMethodInfoPtr_PtrToStringUTF8_Public_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000111E8 File Offset: 0x0000F3E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteropHelp()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000027DE File Offset: 0x000009DE
		public InteropHelp(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_TestIfPlatformSupported_Public_Static_Void_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_TestIfAvailableClient_Public_Static_Void_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_TestIfAvailableGameServer_Public_Static_Void_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_PtrToStringUTF8_Public_Static_String_IntPtr_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000238 RID: 568
		public class UTF8StringHandle : SafeHandleZeroOrMinusOneIsInvalid
		{
			// Token: 0x06001F88 RID: 8072 RVA: 0x0008B528 File Offset: 0x00089728
			// Note: this type is marked as 'beforefieldinit'.
			static UTF8StringHandle()
			{
				Il2CppClassPointerStore<InteropHelp.UTF8StringHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, "UTF8StringHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteropHelp.UTF8StringHandle>.NativeClassPtr);
				InteropHelp.UTF8StringHandle.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp.UTF8StringHandle>.NativeClassPtr, 100663507);
				InteropHelp.UTF8StringHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp.UTF8StringHandle>.NativeClassPtr, 100663508);
			}

			// Token: 0x06001F89 RID: 8073 RVA: 0x0008B57C File Offset: 0x0008977C
			[CallerCount(266)]
			[CachedScanResults(RefRangeStart = 1505, RefRangeEnd = 1771, XrefRangeStart = 1489, XrefRangeEnd = 1505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UTF8StringHandle(string str)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteropHelp.UTF8StringHandle>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.UTF8StringHandle.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F8A RID: 8074 RVA: 0x0008B5C8 File Offset: 0x000897C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1771, XrefRangeEnd = 1774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteropHelp.UTF8StringHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001F8B RID: 8075 RVA: 0x0000B776 File Offset: 0x00009976
			public UTF8StringHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001FCB RID: 8139
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x04001FCC RID: 8140
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}

		// Token: 0x02000239 RID: 569
		public class SteamParamStringArray : Object
		{
			// Token: 0x06001F8C RID: 8076 RVA: 0x0008B610 File Offset: 0x00089810
			// Note: this type is marked as 'beforefieldinit'.
			static SteamParamStringArray()
			{
				Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteropHelp>.NativeClassPtr, "SteamParamStringArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr);
				InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr, "m_Strings");
				InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_ptrStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr, "m_ptrStrings");
				InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_pSteamParamStringArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr, "m_pSteamParamStringArray");
				InteropHelp.SteamParamStringArray.NativeMethodInfoPtr__ctor_Public_Void_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr, 100663509);
				InteropHelp.SteamParamStringArray.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr, 100663510);
				InteropHelp.SteamParamStringArray.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_SteamParamStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr, 100663511);
			}

			// Token: 0x06001F8D RID: 8077 RVA: 0x0008B6B4 File Offset: 0x000898B4
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1828, RefRangeEnd = 1837, XrefRangeStart = 1774, XrefRangeEnd = 1828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SteamParamStringArray(IList<string> strings)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteropHelp.SteamParamStringArray>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(strings);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.SteamParamStringArray.NativeMethodInfoPtr__ctor_Public_Void_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F8E RID: 8078 RVA: 0x0008B700 File Offset: 0x00089900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1837, XrefRangeEnd = 1847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void Finalize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteropHelp.SteamParamStringArray.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F8F RID: 8079 RVA: 0x0008B73C File Offset: 0x0008993C
			[CallerCount(0)]
			public unsafe static implicit operator IntPtr(InteropHelp.SteamParamStringArray that)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(that);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteropHelp.SteamParamStringArray.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_SteamParamStringArray_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F90 RID: 8080 RVA: 0x0000B77F File Offset: 0x0000997F
			public SteamParamStringArray(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700062F RID: 1583
			// (get) Token: 0x06001F91 RID: 8081 RVA: 0x0008B780 File Offset: 0x00089980
			// (set) Token: 0x06001F92 RID: 8082 RVA: 0x0000B788 File Offset: 0x00009988
			public unsafe Il2CppStructArray<IntPtr> m_Strings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_Strings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IntPtr>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_Strings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000630 RID: 1584
			// (get) Token: 0x06001F93 RID: 8083 RVA: 0x0008B7B0 File Offset: 0x000899B0
			// (set) Token: 0x06001F94 RID: 8084 RVA: 0x0000B7A7 File Offset: 0x000099A7
			public unsafe IntPtr m_ptrStrings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_ptrStrings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_ptrStrings)) = value;
				}
			}

			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x06001F95 RID: 8085 RVA: 0x0008B7D8 File Offset: 0x000899D8
			// (set) Token: 0x06001F96 RID: 8086 RVA: 0x0000B7C2 File Offset: 0x000099C2
			public unsafe IntPtr m_pSteamParamStringArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_pSteamParamStringArray);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteropHelp.SteamParamStringArray.NativeFieldInfoPtr_m_pSteamParamStringArray)) = value;
				}
			}

			// Token: 0x04001FCD RID: 8141
			private static readonly IntPtr NativeFieldInfoPtr_m_Strings;

			// Token: 0x04001FCE RID: 8142
			private static readonly IntPtr NativeFieldInfoPtr_m_ptrStrings;

			// Token: 0x04001FCF RID: 8143
			private static readonly IntPtr NativeFieldInfoPtr_m_pSteamParamStringArray;

			// Token: 0x04001FD0 RID: 8144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_String_0;

			// Token: 0x04001FD1 RID: 8145
			private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

			// Token: 0x04001FD2 RID: 8146
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_SteamParamStringArray_0;
		}
	}
}
