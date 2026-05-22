using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200051F RID: 1311
	public class EtwSession : Object
	{
		// Token: 0x06004D46 RID: 19782 RVA: 0x00163BF8 File Offset: 0x00161DF8
		// Note: this type is marked as 'beforefieldinit'.
		static EtwSession()
		{
			Il2CppClassPointerStore<EtwSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EtwSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EtwSession>.NativeClassPtr);
			EtwSession.NativeFieldInfoPtr_m_etwSessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, "m_etwSessionId");
			EtwSession.NativeFieldInfoPtr_m_activityFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, "m_activityFilter");
			EtwSession.NativeFieldInfoPtr_s_etwSessions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, "s_etwSessions");
			EtwSession.NativeMethodInfoPtr_GetEtwSession_Public_Static_EtwSession_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, 100674834);
			EtwSession.NativeMethodInfoPtr_RemoveEtwSession_Public_Static_Void_EtwSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, 100674835);
			EtwSession.NativeMethodInfoPtr_TrimGlobalList_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, 100674836);
			EtwSession.NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, 100674837);
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x00163CB4 File Offset: 0x00161EB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241633, RefRangeEnd = 241634, XrefRangeStart = 241587, XrefRangeEnd = 241633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EtwSession GetEtwSession(int etwSessionId, bool bCreateIfNeeded = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref etwSessionId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreateIfNeeded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.NativeMethodInfoPtr_GetEtwSession_Public_Static_EtwSession_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EtwSession>(intPtr3) : null;
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x00163D04 File Offset: 0x00161F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241656, RefRangeEnd = 241657, XrefRangeStart = 241634, XrefRangeEnd = 241656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveEtwSession(EtwSession etwSession)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(etwSession);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.NativeMethodInfoPtr_RemoveEtwSession_Public_Static_Void_EtwSession_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x00163D3C File Offset: 0x00161F3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 241679, RefRangeEnd = 241681, XrefRangeStart = 241657, XrefRangeEnd = 241679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrimGlobalList()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.NativeMethodInfoPtr_TrimGlobalList_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x00163D64 File Offset: 0x00161F64
		[CallerCount(0)]
		public unsafe EtwSession(int etwSessionId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EtwSession>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref etwSessionId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.NativeMethodInfoPtr__ctor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x0001CCD4 File Offset: 0x0001AED4
		public EtwSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06004D4C RID: 19788 RVA: 0x00163DAC File Offset: 0x00161FAC
		// (set) Token: 0x06004D4D RID: 19789 RVA: 0x0001CCDD File Offset: 0x0001AEDD
		public unsafe int m_etwSessionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EtwSession.NativeFieldInfoPtr_m_etwSessionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EtwSession.NativeFieldInfoPtr_m_etwSessionId)) = value;
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06004D4E RID: 19790 RVA: 0x00163DD4 File Offset: 0x00161FD4
		// (set) Token: 0x06004D4F RID: 19791 RVA: 0x0001CCF8 File Offset: 0x0001AEF8
		public unsafe ActivityFilter m_activityFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EtwSession.NativeFieldInfoPtr_m_activityFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EtwSession.NativeFieldInfoPtr_m_activityFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06004D50 RID: 19792 RVA: 0x00163E04 File Offset: 0x00162004
		// (set) Token: 0x06004D51 RID: 19793 RVA: 0x0001CD17 File Offset: 0x0001AF17
		public unsafe static List<WeakReference<EtwSession>> s_etwSessions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EtwSession.NativeFieldInfoPtr_s_etwSessions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeakReference<EtwSession>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EtwSession.NativeFieldInfoPtr_s_etwSessions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E5D RID: 15965
		private static readonly IntPtr NativeFieldInfoPtr_m_etwSessionId;

		// Token: 0x04003E5E RID: 15966
		private static readonly IntPtr NativeFieldInfoPtr_m_activityFilter;

		// Token: 0x04003E5F RID: 15967
		private static readonly IntPtr NativeFieldInfoPtr_s_etwSessions;

		// Token: 0x04003E60 RID: 15968
		private static readonly IntPtr NativeMethodInfoPtr_GetEtwSession_Public_Static_EtwSession_Int32_Boolean_0;

		// Token: 0x04003E61 RID: 15969
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEtwSession_Public_Static_Void_EtwSession_0;

		// Token: 0x04003E62 RID: 15970
		private static readonly IntPtr NativeMethodInfoPtr_TrimGlobalList_Private_Static_Void_0;

		// Token: 0x04003E63 RID: 15971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;

		// Token: 0x0200068B RID: 1675
		[ObfuscatedName("System.Diagnostics.Tracing.EtwSession+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06005920 RID: 22816 RVA: 0x0018BD68 File Offset: 0x00189F68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<EtwSession.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EtwSession.__c__DisplayClass1_0>.NativeClassPtr);
				EtwSession.__c__DisplayClass1_0.NativeFieldInfoPtr_etwSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtwSession.__c__DisplayClass1_0>.NativeClassPtr, "etwSession");
				EtwSession.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession.__c__DisplayClass1_0>.NativeClassPtr, 100674839);
				EtwSession.__c__DisplayClass1_0.NativeMethodInfoPtr__RemoveEtwSession_b__0_Internal_Boolean_WeakReference_1_EtwSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession.__c__DisplayClass1_0>.NativeClassPtr, 100674840);
			}

			// Token: 0x06005921 RID: 22817 RVA: 0x0018BDD0 File Offset: 0x00189FD0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EtwSession.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005922 RID: 22818 RVA: 0x0018BE0C File Offset: 0x0018A00C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241583, XrefRangeEnd = 241585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveEtwSession_b__0(WeakReference<EtwSession> wrEtwSession)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrEtwSession);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.__c__DisplayClass1_0.NativeMethodInfoPtr__RemoveEtwSession_b__0_Internal_Boolean_WeakReference_1_EtwSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005923 RID: 22819 RVA: 0x0002215D File Offset: 0x0002035D
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001715 RID: 5909
			// (get) Token: 0x06005924 RID: 22820 RVA: 0x0018BE5C File Offset: 0x0018A05C
			// (set) Token: 0x06005925 RID: 22821 RVA: 0x00022166 File Offset: 0x00020366
			public unsafe EtwSession etwSession
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EtwSession.__c__DisplayClass1_0.NativeFieldInfoPtr_etwSession);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EtwSession>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EtwSession.__c__DisplayClass1_0.NativeFieldInfoPtr_etwSession), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004760 RID: 18272
			private static readonly IntPtr NativeFieldInfoPtr_etwSession;

			// Token: 0x04004761 RID: 18273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004762 RID: 18274
			private static readonly IntPtr NativeMethodInfoPtr__RemoveEtwSession_b__0_Internal_Boolean_WeakReference_1_EtwSession_0;
		}

		// Token: 0x0200068C RID: 1676
		[ObfuscatedName("System.Diagnostics.Tracing.EtwSession+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005926 RID: 22822 RVA: 0x0018BE8C File Offset: 0x0018A08C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EtwSession>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr);
				EtwSession.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr, "<>9");
				EtwSession.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr, "<>9__2_0");
				EtwSession.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr, 100674842);
				EtwSession.__c.NativeMethodInfoPtr__TrimGlobalList_b__2_0_Internal_Boolean_WeakReference_1_EtwSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr, 100674843);
			}

			// Token: 0x06005927 RID: 22823 RVA: 0x0018BF08 File Offset: 0x0018A108
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EtwSession.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005928 RID: 22824 RVA: 0x0018BF44 File Offset: 0x0018A144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241585, XrefRangeEnd = 241587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TrimGlobalList_b__2_0(WeakReference<EtwSession> wrEtwSession)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wrEtwSession);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EtwSession.__c.NativeMethodInfoPtr__TrimGlobalList_b__2_0_Internal_Boolean_WeakReference_1_EtwSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005929 RID: 22825 RVA: 0x00022185 File Offset: 0x00020385
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001716 RID: 5910
			// (get) Token: 0x0600592A RID: 22826 RVA: 0x0018BF94 File Offset: 0x0018A194
			// (set) Token: 0x0600592B RID: 22827 RVA: 0x0002218E File Offset: 0x0002038E
			public unsafe static EtwSession.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EtwSession.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EtwSession.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EtwSession.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001717 RID: 5911
			// (get) Token: 0x0600592C RID: 22828 RVA: 0x0018BFBC File Offset: 0x0018A1BC
			// (set) Token: 0x0600592D RID: 22829 RVA: 0x000221A0 File Offset: 0x000203A0
			public unsafe static Predicate<WeakReference<EtwSession>> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EtwSession.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<WeakReference<EtwSession>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EtwSession.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004763 RID: 18275
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004764 RID: 18276
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04004765 RID: 18277
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004766 RID: 18278
			private static readonly IntPtr NativeMethodInfoPtr__TrimGlobalList_b__2_0_Internal_Boolean_WeakReference_1_EtwSession_0;
		}
	}
}
