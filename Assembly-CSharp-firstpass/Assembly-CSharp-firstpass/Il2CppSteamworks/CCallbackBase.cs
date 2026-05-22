using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSteamworks
{
	// Token: 0x0200000E RID: 14
	public class CCallbackBase : Object
	{
		// Token: 0x06000083 RID: 131 RVA: 0x0000F988 File Offset: 0x0000DB88
		// Note: this type is marked as 'beforefieldinit'.
		static CCallbackBase()
		{
			Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CCallbackBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr);
			CCallbackBase.NativeFieldInfoPtr_k_ECallbackFlagsRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr, "k_ECallbackFlagsRegistered");
			CCallbackBase.NativeFieldInfoPtr_k_ECallbackFlagsGameServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr, "k_ECallbackFlagsGameServer");
			CCallbackBase.NativeFieldInfoPtr_m_vfptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr, "m_vfptr");
			CCallbackBase.NativeFieldInfoPtr_m_nCallbackFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr, "m_nCallbackFlags");
			CCallbackBase.NativeFieldInfoPtr_m_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr, "m_iCallback");
			CCallbackBase.NativeFieldInfoPtr_registeredCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr, "registeredCallbacks");
			CCallbackBase.NativeMethodInfoPtr_Register_Internal_Static_Void_IntPtr_ICallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr, 100663361);
			CCallbackBase.NativeMethodInfoPtr_Unregister_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr, 100663362);
			CCallbackBase.NativeMethodInfoPtr_GetRegisteredCallback_Private_Static_ICallback_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr, 100663363);
			CCallbackBase.NativeMethodInfoPtr_OnRunCallback_Internal_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr, 100663364);
			CCallbackBase.NativeMethodInfoPtr_OnRunCallResult_Internal_Static_Void_IntPtr_IntPtr_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr, 100663365);
			CCallbackBase.NativeMethodInfoPtr_OnGetCallbackSizeBytes_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr, 100663366);
			CCallbackBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr, 100663367);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000FABC File Offset: 0x0000DCBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 820, RefRangeEnd = 822, XrefRangeStart = 814, XrefRangeEnd = 820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register(IntPtr thisptr, ICallback callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBase.NativeMethodInfoPtr_Register_Internal_Static_Void_IntPtr_ICallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000FB00 File Offset: 0x0000DD00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 830, RefRangeEnd = 834, XrefRangeStart = 822, XrefRangeEnd = 830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Unregister(IntPtr thisptr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBase.NativeMethodInfoPtr_Unregister_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000FB34 File Offset: 0x0000DD34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 840, RefRangeEnd = 843, XrefRangeStart = 834, XrefRangeEnd = 840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICallback GetRegisteredCallback(IntPtr thisptr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBase.NativeMethodInfoPtr_GetRegisteredCallback_Private_Static_ICallback_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICallback>(intPtr3) : null;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000FB74 File Offset: 0x0000DD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 843, XrefRangeEnd = 850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnRunCallback(IntPtr thisptr, IntPtr pvParam)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvParam;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBase.NativeMethodInfoPtr_OnRunCallback_Internal_Static_Void_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000FBB4 File Offset: 0x0000DDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850, XrefRangeEnd = 857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnRunCallResult(IntPtr thisptr, IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pvParam;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bFailed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamAPICall;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBase.NativeMethodInfoPtr_OnRunCallResult_Internal_Static_Void_IntPtr_IntPtr_Boolean_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000FC10 File Offset: 0x0000DE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857, XrefRangeEnd = 862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int OnGetCallbackSizeBytes(IntPtr thisptr)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBase.NativeMethodInfoPtr_OnGetCallbackSizeBytes_Internal_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000FC50 File Offset: 0x0000DE50
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CCallbackBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CCallbackBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CCallbackBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000023E8 File Offset: 0x000005E8
		public CCallbackBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000FC8C File Offset: 0x0000DE8C
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000023F1 File Offset: 0x000005F1
		public unsafe static byte k_ECallbackFlagsRegistered
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(CCallbackBase.NativeFieldInfoPtr_k_ECallbackFlagsRegistered, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CCallbackBase.NativeFieldInfoPtr_k_ECallbackFlagsRegistered, (void*)(&value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000023FF File Offset: 0x000005FF
		public unsafe static byte k_ECallbackFlagsGameServer
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(CCallbackBase.NativeFieldInfoPtr_k_ECallbackFlagsGameServer, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CCallbackBase.NativeFieldInfoPtr_k_ECallbackFlagsGameServer, (void*)(&value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000FCC4 File Offset: 0x0000DEC4
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000240D File Offset: 0x0000060D
		public unsafe IntPtr m_vfptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CCallbackBase.NativeFieldInfoPtr_m_vfptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CCallbackBase.NativeFieldInfoPtr_m_vfptr)) = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000FCEC File Offset: 0x0000DEEC
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002428 File Offset: 0x00000628
		public unsafe byte m_nCallbackFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CCallbackBase.NativeFieldInfoPtr_m_nCallbackFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CCallbackBase.NativeFieldInfoPtr_m_nCallbackFlags)) = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000FD14 File Offset: 0x0000DF14
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002443 File Offset: 0x00000643
		public unsafe int m_iCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CCallbackBase.NativeFieldInfoPtr_m_iCallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CCallbackBase.NativeFieldInfoPtr_m_iCallback)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000FD3C File Offset: 0x0000DF3C
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000245E File Offset: 0x0000065E
		public unsafe static Dictionary<IntPtr, ICallback> registeredCallbacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CCallbackBase.NativeFieldInfoPtr_registeredCallbacks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IntPtr, ICallback>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CCallbackBase.NativeFieldInfoPtr_registeredCallbacks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_k_ECallbackFlagsRegistered;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_k_ECallbackFlagsGameServer;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_m_vfptr;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_m_nCallbackFlags;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_m_iCallback;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_registeredCallbacks;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_Register_Internal_Static_Void_IntPtr_ICallback_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Internal_Static_Void_IntPtr_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_GetRegisteredCallback_Private_Static_ICallback_IntPtr_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_OnRunCallback_Internal_Static_Void_IntPtr_IntPtr_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_OnRunCallResult_Internal_Static_Void_IntPtr_IntPtr_Boolean_UInt64_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_OnGetCallbackSizeBytes_Internal_Static_Int32_IntPtr_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
