using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSteamworks
{
	// Token: 0x02000015 RID: 21
	public class ISteamMatchmakingRulesResponse : Object
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x00010CA8 File Offset: 0x0000EEA8
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMatchmakingRulesResponse()
		{
			Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ISteamMatchmakingRulesResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr);
			ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_VTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "m_VTable");
			ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_pVTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "m_pVTable");
			ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_pGCHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "m_pGCHandle");
			ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesResponded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "m_RulesResponded");
			ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "m_RulesFailedToRespond");
			ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesRefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "m_RulesRefreshComplete");
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr__ctor_Public_Void_RulesResponded_RulesFailedToRespond_RulesRefreshComplete_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100663471);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100663472);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_InternalOnRulesResponded_Private_Void_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100663473);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_InternalOnRulesFailedToRespond_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100663474);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_InternalOnRulesRefreshComplete_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100663475);
			ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingRulesResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, 100663476);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00010DC8 File Offset: 0x0000EFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1438, XrefRangeEnd = 1479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMatchmakingRulesResponse(ISteamMatchmakingRulesResponse.RulesResponded onRulesResponded, ISteamMatchmakingRulesResponse.RulesFailedToRespond onRulesFailedToRespond, ISteamMatchmakingRulesResponse.RulesRefreshComplete onRulesRefreshComplete)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onRulesResponded);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRulesFailedToRespond);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRulesRefreshComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr__ctor_Public_Void_RulesResponded_RulesFailedToRespond_RulesRefreshComplete_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00010E38 File Offset: 0x0000F038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1479, XrefRangeEnd = 1485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00010E74 File Offset: 0x0000F074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1485, XrefRangeEnd = 1489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnRulesResponded(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchRule;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_InternalOnRulesResponded_Private_Void_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00010ED0 File Offset: 0x0000F0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnRulesFailedToRespond(IntPtr thisptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_InternalOnRulesFailedToRespond_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00010F10 File Offset: 0x0000F110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalOnRulesRefreshComplete(IntPtr thisptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref thisptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_InternalOnRulesRefreshComplete_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00010F50 File Offset: 0x0000F150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator IntPtr(ISteamMatchmakingRulesResponse that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(that);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingRulesResponse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002723 File Offset: 0x00000923
		public ISteamMatchmakingRulesResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00010F94 File Offset: 0x0000F194
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000272C File Offset: 0x0000092C
		public unsafe ISteamMatchmakingRulesResponse.VTable m_VTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_VTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.VTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_VTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00010FC4 File Offset: 0x0000F1C4
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000274B File Offset: 0x0000094B
		public unsafe IntPtr m_pVTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_pVTable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_pVTable)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00010FEC File Offset: 0x0000F1EC
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002766 File Offset: 0x00000966
		public unsafe GCHandle m_pGCHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_pGCHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_pGCHandle)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00011014 File Offset: 0x0000F214
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002781 File Offset: 0x00000981
		public unsafe ISteamMatchmakingRulesResponse.RulesResponded m_RulesResponded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesResponded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.RulesResponded>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesResponded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00011044 File Offset: 0x0000F244
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000027A0 File Offset: 0x000009A0
		public unsafe ISteamMatchmakingRulesResponse.RulesFailedToRespond m_RulesFailedToRespond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesFailedToRespond);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.RulesFailedToRespond>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00011074 File Offset: 0x0000F274
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000027BF File Offset: 0x000009BF
		public unsafe ISteamMatchmakingRulesResponse.RulesRefreshComplete m_RulesRefreshComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesRefreshComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.RulesRefreshComplete>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.NativeFieldInfoPtr_m_RulesRefreshComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_m_VTable;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_m_pVTable;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_m_pGCHandle;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_m_RulesResponded;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_m_RulesFailedToRespond;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_m_RulesRefreshComplete;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RulesResponded_RulesFailedToRespond_RulesRefreshComplete_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnRulesResponded_Private_Void_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnRulesFailedToRespond_Private_Void_IntPtr_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnRulesRefreshComplete_Private_Void_IntPtr_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_IntPtr_ISteamMatchmakingRulesResponse_0;

		// Token: 0x02000231 RID: 561
		public sealed class RulesResponded : MulticastDelegate
		{
			// Token: 0x06001F49 RID: 8009 RVA: 0x0008A910 File Offset: 0x00088B10
			// Note: this type is marked as 'beforefieldinit'.
			static RulesResponded()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesResponded>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "RulesResponded");
				ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesResponded>.NativeClassPtr, 100663477);
				ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesResponded>.NativeClassPtr, 100663478);
				ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesResponded>.NativeClassPtr, 100663479);
				ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesResponded>.NativeClassPtr, 100663480);
			}

			// Token: 0x06001F4A RID: 8010 RVA: 0x0008A984 File Offset: 0x00088B84
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RulesResponded(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesResponded>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F4B RID: 8011 RVA: 0x0008A9E0 File Offset: 0x00088BE0
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 1337, RefRangeEnd = 1421, XrefRangeStart = 1337, XrefRangeEnd = 1337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string pchRule, string pchValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(pchRule);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F4C RID: 8012 RVA: 0x0008AA34 File Offset: 0x00088C34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421, XrefRangeEnd = 1422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string pchRule, string pchValue, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(pchRule);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F4D RID: 8013 RVA: 0x0008AABC File Offset: 0x00088CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F4E RID: 8014 RVA: 0x0000B5F0 File Offset: 0x000097F0
			public RulesResponded(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F4F RID: 8015 RVA: 0x0000B5F9 File Offset: 0x000097F9
			public static implicit operator ISteamMatchmakingRulesResponse.RulesResponded(Action<string, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingRulesResponse.RulesResponded>(A_0);
			}

			// Token: 0x06001F50 RID: 8016 RVA: 0x0000B601 File Offset: 0x00009801
			public static ISteamMatchmakingRulesResponse.RulesResponded operator +(ISteamMatchmakingRulesResponse.RulesResponded A_0, ISteamMatchmakingRulesResponse.RulesResponded A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingRulesResponse.RulesResponded>();
			}

			// Token: 0x06001F51 RID: 8017 RVA: 0x0000B60F File Offset: 0x0000980F
			public static ISteamMatchmakingRulesResponse.RulesResponded operator -(ISteamMatchmakingRulesResponse.RulesResponded A_0, ISteamMatchmakingRulesResponse.RulesResponded A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingRulesResponse.RulesResponded>();
				}
				return delegate2;
			}

			// Token: 0x04001FAF RID: 8111
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001FB0 RID: 8112
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_0;

			// Token: 0x04001FB1 RID: 8113
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_AsyncCallback_Object_0;

			// Token: 0x04001FB2 RID: 8114
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000232 RID: 562
		public sealed class RulesFailedToRespond : MulticastDelegate
		{
			// Token: 0x06001F52 RID: 8018 RVA: 0x0008AB00 File Offset: 0x00088D00
			// Note: this type is marked as 'beforefieldinit'.
			static RulesFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "RulesFailedToRespond");
				ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesFailedToRespond>.NativeClassPtr, 100663481);
				ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesFailedToRespond>.NativeClassPtr, 100663482);
				ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesFailedToRespond>.NativeClassPtr, 100663483);
				ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesFailedToRespond>.NativeClassPtr, 100663484);
			}

			// Token: 0x06001F53 RID: 8019 RVA: 0x0008AB74 File Offset: 0x00088D74
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RulesFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F54 RID: 8020 RVA: 0x0008ABD0 File Offset: 0x00088DD0
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F55 RID: 8021 RVA: 0x0008AC04 File Offset: 0x00088E04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F56 RID: 8022 RVA: 0x0008AC68 File Offset: 0x00088E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F57 RID: 8023 RVA: 0x0000B620 File Offset: 0x00009820
			public RulesFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F58 RID: 8024 RVA: 0x0000B629 File Offset: 0x00009829
			public static implicit operator ISteamMatchmakingRulesResponse.RulesFailedToRespond(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingRulesResponse.RulesFailedToRespond>(A_0);
			}

			// Token: 0x06001F59 RID: 8025 RVA: 0x0000B631 File Offset: 0x00009831
			public static ISteamMatchmakingRulesResponse.RulesFailedToRespond operator +(ISteamMatchmakingRulesResponse.RulesFailedToRespond A_0, ISteamMatchmakingRulesResponse.RulesFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingRulesResponse.RulesFailedToRespond>();
			}

			// Token: 0x06001F5A RID: 8026 RVA: 0x0000B63F File Offset: 0x0000983F
			public static ISteamMatchmakingRulesResponse.RulesFailedToRespond operator -(ISteamMatchmakingRulesResponse.RulesFailedToRespond A_0, ISteamMatchmakingRulesResponse.RulesFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingRulesResponse.RulesFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x04001FB3 RID: 8115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001FB4 RID: 8116
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04001FB5 RID: 8117
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04001FB6 RID: 8118
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000233 RID: 563
		public sealed class RulesRefreshComplete : MulticastDelegate
		{
			// Token: 0x06001F5B RID: 8027 RVA: 0x0008ACAC File Offset: 0x00088EAC
			// Note: this type is marked as 'beforefieldinit'.
			static RulesRefreshComplete()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesRefreshComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "RulesRefreshComplete");
				ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesRefreshComplete>.NativeClassPtr, 100663485);
				ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesRefreshComplete>.NativeClassPtr, 100663486);
				ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesRefreshComplete>.NativeClassPtr, 100663487);
				ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesRefreshComplete>.NativeClassPtr, 100663488);
			}

			// Token: 0x06001F5C RID: 8028 RVA: 0x0008AD20 File Offset: 0x00088F20
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RulesRefreshComplete(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.RulesRefreshComplete>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F5D RID: 8029 RVA: 0x0008AD7C File Offset: 0x00088F7C
			[CallerCount(171)]
			[CachedScanResults(RefRangeStart = 1023, RefRangeEnd = 1194, XrefRangeStart = 1023, XrefRangeEnd = 1194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F5E RID: 8030 RVA: 0x0008ADB0 File Offset: 0x00088FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F5F RID: 8031 RVA: 0x0008AE14 File Offset: 0x00089014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.RulesRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F60 RID: 8032 RVA: 0x0000B650 File Offset: 0x00009850
			public RulesRefreshComplete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F61 RID: 8033 RVA: 0x0000B659 File Offset: 0x00009859
			public static implicit operator ISteamMatchmakingRulesResponse.RulesRefreshComplete(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingRulesResponse.RulesRefreshComplete>(A_0);
			}

			// Token: 0x06001F62 RID: 8034 RVA: 0x0000B661 File Offset: 0x00009861
			public static ISteamMatchmakingRulesResponse.RulesRefreshComplete operator +(ISteamMatchmakingRulesResponse.RulesRefreshComplete A_0, ISteamMatchmakingRulesResponse.RulesRefreshComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingRulesResponse.RulesRefreshComplete>();
			}

			// Token: 0x06001F63 RID: 8035 RVA: 0x0000B66F File Offset: 0x0000986F
			public static ISteamMatchmakingRulesResponse.RulesRefreshComplete operator -(ISteamMatchmakingRulesResponse.RulesRefreshComplete A_0, ISteamMatchmakingRulesResponse.RulesRefreshComplete A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingRulesResponse.RulesRefreshComplete>();
				}
				return delegate2;
			}

			// Token: 0x04001FB7 RID: 8119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001FB8 RID: 8120
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04001FB9 RID: 8121
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04001FBA RID: 8122
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000234 RID: 564
		public sealed class InternalRulesResponded : MulticastDelegate
		{
			// Token: 0x06001F64 RID: 8036 RVA: 0x0008AE58 File Offset: 0x00089058
			// Note: this type is marked as 'beforefieldinit'.
			static InternalRulesResponded()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesResponded>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "InternalRulesResponded");
				ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesResponded>.NativeClassPtr, 100663489);
				ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesResponded>.NativeClassPtr, 100663490);
				ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesResponded>.NativeClassPtr, 100663491);
				ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesResponded>.NativeClassPtr, 100663492);
			}

			// Token: 0x06001F65 RID: 8037 RVA: 0x0008AECC File Offset: 0x000890CC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalRulesResponded(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesResponded>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F66 RID: 8038 RVA: 0x0008AF28 File Offset: 0x00089128
			[CallerCount(0)]
			public unsafe void Invoke(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchRule;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F67 RID: 8039 RVA: 0x0008AF84 File Offset: 0x00089184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1422, XrefRangeEnd = 1430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, IntPtr pchRule, IntPtr pchValue, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchRule;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchValue;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F68 RID: 8040 RVA: 0x0008B014 File Offset: 0x00089214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesResponded.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F69 RID: 8041 RVA: 0x0000B680 File Offset: 0x00009880
			public InternalRulesResponded(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F6A RID: 8042 RVA: 0x0000B689 File Offset: 0x00009889
			public static implicit operator ISteamMatchmakingRulesResponse.InternalRulesResponded(Action<IntPtr, IntPtr, IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingRulesResponse.InternalRulesResponded>(A_0);
			}

			// Token: 0x06001F6B RID: 8043 RVA: 0x0000B691 File Offset: 0x00009891
			public static ISteamMatchmakingRulesResponse.InternalRulesResponded operator +(ISteamMatchmakingRulesResponse.InternalRulesResponded A_0, ISteamMatchmakingRulesResponse.InternalRulesResponded A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingRulesResponse.InternalRulesResponded>();
			}

			// Token: 0x06001F6C RID: 8044 RVA: 0x0000B69F File Offset: 0x0000989F
			public static ISteamMatchmakingRulesResponse.InternalRulesResponded operator -(ISteamMatchmakingRulesResponse.InternalRulesResponded A_0, ISteamMatchmakingRulesResponse.InternalRulesResponded A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingRulesResponse.InternalRulesResponded>();
				}
				return delegate2;
			}

			// Token: 0x04001FBB RID: 8123
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001FBC RID: 8124
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_0;

			// Token: 0x04001FBD RID: 8125
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_AsyncCallback_Object_0;

			// Token: 0x04001FBE RID: 8126
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000235 RID: 565
		public sealed class InternalRulesFailedToRespond : MulticastDelegate
		{
			// Token: 0x06001F6D RID: 8045 RVA: 0x0008B058 File Offset: 0x00089258
			// Note: this type is marked as 'beforefieldinit'.
			static InternalRulesFailedToRespond()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "InternalRulesFailedToRespond");
				ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>.NativeClassPtr, 100663493);
				ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>.NativeClassPtr, 100663494);
				ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>.NativeClassPtr, 100663495);
				ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>.NativeClassPtr, 100663496);
			}

			// Token: 0x06001F6E RID: 8046 RVA: 0x0008B0CC File Offset: 0x000892CC
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalRulesFailedToRespond(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F6F RID: 8047 RVA: 0x0008B128 File Offset: 0x00089328
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1199, RefRangeEnd = 1208, XrefRangeStart = 1199, XrefRangeEnd = 1208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F70 RID: 8048 RVA: 0x0008B168 File Offset: 0x00089368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430, XrefRangeEnd = 1434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F71 RID: 8049 RVA: 0x0008B1D8 File Offset: 0x000893D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F72 RID: 8050 RVA: 0x0000B6B0 File Offset: 0x000098B0
			public InternalRulesFailedToRespond(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F73 RID: 8051 RVA: 0x0000B6B9 File Offset: 0x000098B9
			public static implicit operator ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond(Action<IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>(A_0);
			}

			// Token: 0x06001F74 RID: 8052 RVA: 0x0000B6C1 File Offset: 0x000098C1
			public static ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond operator +(ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond A_0, ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>();
			}

			// Token: 0x06001F75 RID: 8053 RVA: 0x0000B6CF File Offset: 0x000098CF
			public static ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond operator -(ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond A_0, ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>();
				}
				return delegate2;
			}

			// Token: 0x04001FBF RID: 8127
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001FC0 RID: 8128
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

			// Token: 0x04001FC1 RID: 8129
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

			// Token: 0x04001FC2 RID: 8130
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000236 RID: 566
		public sealed class InternalRulesRefreshComplete : MulticastDelegate
		{
			// Token: 0x06001F76 RID: 8054 RVA: 0x0008B21C File Offset: 0x0008941C
			// Note: this type is marked as 'beforefieldinit'.
			static InternalRulesRefreshComplete()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "InternalRulesRefreshComplete");
				ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>.NativeClassPtr, 100663497);
				ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>.NativeClassPtr, 100663498);
				ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>.NativeClassPtr, 100663499);
				ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>.NativeClassPtr, 100663500);
			}

			// Token: 0x06001F77 RID: 8055 RVA: 0x0008B290 File Offset: 0x00089490
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InternalRulesRefreshComplete(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F78 RID: 8056 RVA: 0x0008B2EC File Offset: 0x000894EC
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1199, RefRangeEnd = 1208, XrefRangeStart = 1199, XrefRangeEnd = 1208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IntPtr thisptr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F79 RID: 8057 RVA: 0x0008B32C File Offset: 0x0008952C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434, XrefRangeEnd = 1438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr thisptr, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref thisptr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F7A RID: 8058 RVA: 0x0008B39C File Offset: 0x0008959C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F7B RID: 8059 RVA: 0x0000B6E0 File Offset: 0x000098E0
			public InternalRulesRefreshComplete(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F7C RID: 8060 RVA: 0x0000B6E9 File Offset: 0x000098E9
			public static implicit operator ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete(Action<IntPtr> A_0)
			{
				return DelegateSupport.ConvertDelegate<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>(A_0);
			}

			// Token: 0x06001F7D RID: 8061 RVA: 0x0000B6F1 File Offset: 0x000098F1
			public static ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete operator +(ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete A_0, ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>();
			}

			// Token: 0x06001F7E RID: 8062 RVA: 0x0000B6FF File Offset: 0x000098FF
			public static ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete operator -(ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete A_0, ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>();
				}
				return delegate2;
			}

			// Token: 0x04001FC3 RID: 8131
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001FC4 RID: 8132
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

			// Token: 0x04001FC5 RID: 8133
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

			// Token: 0x04001FC6 RID: 8134
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000237 RID: 567
		public class VTable : Object
		{
			// Token: 0x06001F7F RID: 8063 RVA: 0x0008B3E0 File Offset: 0x000895E0
			// Note: this type is marked as 'beforefieldinit'.
			static VTable()
			{
				Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse>.NativeClassPtr, "VTable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr);
				ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesResponded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr, "m_VTRulesResponded");
				ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesFailedToRespond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr, "m_VTRulesFailedToRespond");
				ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesRefreshComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr, "m_VTRulesRefreshComplete");
				ISteamMatchmakingRulesResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr, 100663501);
			}

			// Token: 0x06001F80 RID: 8064 RVA: 0x0008B45C File Offset: 0x0008965C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VTable()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMatchmakingRulesResponse.VTable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMatchmakingRulesResponse.VTable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F81 RID: 8065 RVA: 0x0000B710 File Offset: 0x00009910
			public VTable(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700062C RID: 1580
			// (get) Token: 0x06001F82 RID: 8066 RVA: 0x0008B498 File Offset: 0x00089698
			// (set) Token: 0x06001F83 RID: 8067 RVA: 0x0000B719 File Offset: 0x00009919
			public unsafe ISteamMatchmakingRulesResponse.InternalRulesResponded m_VTRulesResponded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesResponded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.InternalRulesResponded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesResponded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062D RID: 1581
			// (get) Token: 0x06001F84 RID: 8068 RVA: 0x0008B4C8 File Offset: 0x000896C8
			// (set) Token: 0x06001F85 RID: 8069 RVA: 0x0000B738 File Offset: 0x00009938
			public unsafe ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond m_VTRulesFailedToRespond
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesFailedToRespond);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.InternalRulesFailedToRespond>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesFailedToRespond), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062E RID: 1582
			// (get) Token: 0x06001F86 RID: 8070 RVA: 0x0008B4F8 File Offset: 0x000896F8
			// (set) Token: 0x06001F87 RID: 8071 RVA: 0x0000B757 File Offset: 0x00009957
			public unsafe ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete m_VTRulesRefreshComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesRefreshComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingRulesResponse.InternalRulesRefreshComplete>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ISteamMatchmakingRulesResponse.VTable.NativeFieldInfoPtr_m_VTRulesRefreshComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FC7 RID: 8135
			private static readonly IntPtr NativeFieldInfoPtr_m_VTRulesResponded;

			// Token: 0x04001FC8 RID: 8136
			private static readonly IntPtr NativeFieldInfoPtr_m_VTRulesFailedToRespond;

			// Token: 0x04001FC9 RID: 8137
			private static readonly IntPtr NativeFieldInfoPtr_m_VTRulesRefreshComplete;

			// Token: 0x04001FCA RID: 8138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
