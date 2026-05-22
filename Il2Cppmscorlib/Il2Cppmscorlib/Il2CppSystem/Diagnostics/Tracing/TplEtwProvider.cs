using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000510 RID: 1296
	public class TplEtwProvider : EventSource
	{
		// Token: 0x06004C49 RID: 19529 RVA: 0x00160414 File Offset: 0x0015E614
		// Note: this type is marked as 'beforefieldinit'.
		static TplEtwProvider()
		{
			Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "TplEtwProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr);
			TplEtwProvider.NativeFieldInfoPtr_Log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, "Log");
			TplEtwProvider.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, 100674713);
			TplEtwProvider.NativeMethodInfoPtr_DebugFacilityMessage_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, 100674714);
			TplEtwProvider.NativeMethodInfoPtr_DebugFacilityMessage1_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, 100674715);
			TplEtwProvider.NativeMethodInfoPtr_SetActivityId_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, 100674716);
			TplEtwProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, 100674717);
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06004C4A RID: 19530 RVA: 0x001604BC File Offset: 0x0015E6BC
		public unsafe bool Debug
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TplEtwProvider.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x001604F8 File Offset: 0x0015E6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240702, XrefRangeEnd = 240703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugFacilityMessage(string Facility, string Message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Facility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TplEtwProvider.NativeMethodInfoPtr_DebugFacilityMessage_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x0016054C File Offset: 0x0015E74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240703, XrefRangeEnd = 240704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugFacilityMessage1(string Facility, string Message, string Arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Facility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TplEtwProvider.NativeMethodInfoPtr_DebugFacilityMessage1_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x001605B4 File Offset: 0x0015E7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240704, XrefRangeEnd = 240713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActivityId(Guid Id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TplEtwProvider.NativeMethodInfoPtr_SetActivityId_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x001605F4 File Offset: 0x0015E7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240713, XrefRangeEnd = 240725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TplEtwProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TplEtwProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x0001C55A File Offset: 0x0001A75A
		public TplEtwProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06004C50 RID: 19536 RVA: 0x00160630 File Offset: 0x0015E830
		// (set) Token: 0x06004C51 RID: 19537 RVA: 0x0001C563 File Offset: 0x0001A763
		public unsafe static TplEtwProvider Log
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TplEtwProvider.NativeFieldInfoPtr_Log, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TplEtwProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TplEtwProvider.NativeFieldInfoPtr_Log, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D93 RID: 15763
		private static readonly IntPtr NativeFieldInfoPtr_Log;

		// Token: 0x04003D94 RID: 15764
		private static readonly IntPtr NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0;

		// Token: 0x04003D95 RID: 15765
		private static readonly IntPtr NativeMethodInfoPtr_DebugFacilityMessage_Public_Void_String_String_0;

		// Token: 0x04003D96 RID: 15766
		private static readonly IntPtr NativeMethodInfoPtr_DebugFacilityMessage1_Public_Void_String_String_String_0;

		// Token: 0x04003D97 RID: 15767
		private static readonly IntPtr NativeMethodInfoPtr_SetActivityId_Public_Void_Guid_0;

		// Token: 0x04003D98 RID: 15768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000682 RID: 1666
		public class Keywords : Object
		{
			// Token: 0x060058EA RID: 22762 RVA: 0x00021F6B File Offset: 0x0002016B
			// Note: this type is marked as 'beforefieldinit'.
			static Keywords()
			{
				Il2CppClassPointerStore<TplEtwProvider.Keywords>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TplEtwProvider>.NativeClassPtr, "Keywords");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TplEtwProvider.Keywords>.NativeClassPtr);
				TplEtwProvider.Keywords.NativeFieldInfoPtr_Debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TplEtwProvider.Keywords>.NativeClassPtr, "Debug");
			}

			// Token: 0x060058EB RID: 22763 RVA: 0x00021F9F File Offset: 0x0002019F
			public Keywords(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001708 RID: 5896
			// (get) Token: 0x060058EC RID: 22764 RVA: 0x0018B410 File Offset: 0x00189610
			// (set) Token: 0x060058ED RID: 22765 RVA: 0x00021FA8 File Offset: 0x000201A8
			public unsafe static EventKeywords Debug
			{
				get
				{
					EventKeywords eventKeywords;
					IL2CPP.il2cpp_field_static_get_value(TplEtwProvider.Keywords.NativeFieldInfoPtr_Debug, (void*)(&eventKeywords));
					return eventKeywords;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TplEtwProvider.Keywords.NativeFieldInfoPtr_Debug, (void*)(&value));
				}
			}

			// Token: 0x04004734 RID: 18228
			private static readonly IntPtr NativeFieldInfoPtr_Debug;
		}
	}
}
