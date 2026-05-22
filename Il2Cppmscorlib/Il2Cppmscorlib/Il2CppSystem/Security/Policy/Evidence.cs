using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Security.Policy
{
	// Token: 0x020002C7 RID: 711
	[Serializable]
	public sealed class Evidence : Object
	{
		// Token: 0x0600303E RID: 12350 RVA: 0x000F4848 File Offset: 0x000F2A48
		// Note: this type is marked as 'beforefieldinit'.
		static Evidence()
		{
			Il2CppClassPointerStore<Evidence>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Policy", "Evidence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Evidence>.NativeClassPtr);
			Evidence.NativeFieldInfoPtr__locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence>.NativeClassPtr, "_locked");
			Evidence.NativeFieldInfoPtr_hostEvidenceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence>.NativeClassPtr, "hostEvidenceList");
			Evidence.NativeFieldInfoPtr_assemblyEvidenceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence>.NativeClassPtr, "assemblyEvidenceList");
			Evidence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100670986);
			Evidence.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100670987);
			Evidence.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100670988);
			Evidence.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100670989);
			Evidence.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100670990);
			Evidence.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence>.NativeClassPtr, 100670991);
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x000F492C File Offset: 0x000F2B2C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Evidence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Evidence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06003040 RID: 12352 RVA: 0x000F4968 File Offset: 0x000F2B68
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06003041 RID: 12353 RVA: 0x000F49A4 File Offset: 0x000F2BA4
		public unsafe bool IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06003042 RID: 12354 RVA: 0x000F49E0 File Offset: 0x000F2BE0
		public unsafe Object SyncRoot
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x000F4A20 File Offset: 0x000F2C20
		[CallerCount(0)]
		public unsafe void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x000F4A70 File Offset: 0x000F2C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208149, XrefRangeEnd = 208152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x00010A96 File Offset: 0x0000EC96
		public Evidence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06003046 RID: 12358 RVA: 0x000F4AB0 File Offset: 0x000F2CB0
		// (set) Token: 0x06003047 RID: 12359 RVA: 0x00010A9F File Offset: 0x0000EC9F
		public unsafe bool _locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr__locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr__locked)) = value;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06003048 RID: 12360 RVA: 0x000F4AD8 File Offset: 0x000F2CD8
		// (set) Token: 0x06003049 RID: 12361 RVA: 0x00010ABA File Offset: 0x0000ECBA
		public unsafe ArrayList hostEvidenceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr_hostEvidenceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr_hostEvidenceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x000F4B08 File Offset: 0x000F2D08
		// (set) Token: 0x0600304B RID: 12363 RVA: 0x00010AD9 File Offset: 0x0000ECD9
		public unsafe ArrayList assemblyEvidenceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr_assemblyEvidenceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.NativeFieldInfoPtr_assemblyEvidenceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040029A5 RID: 10661
		private static readonly IntPtr NativeFieldInfoPtr__locked;

		// Token: 0x040029A6 RID: 10662
		private static readonly IntPtr NativeFieldInfoPtr_hostEvidenceList;

		// Token: 0x040029A7 RID: 10663
		private static readonly IntPtr NativeFieldInfoPtr_assemblyEvidenceList;

		// Token: 0x040029A8 RID: 10664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040029A9 RID: 10665
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040029AA RID: 10666
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040029AB RID: 10667
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040029AC RID: 10668
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040029AD RID: 10669
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x02000621 RID: 1569
		public class EvidenceEnumerator : Object
		{
			// Token: 0x0600554B RID: 21835 RVA: 0x0017E4E0 File Offset: 0x0017C6E0
			// Note: this type is marked as 'beforefieldinit'.
			static EvidenceEnumerator()
			{
				Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Evidence>.NativeClassPtr, "EvidenceEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr);
				Evidence.EvidenceEnumerator.NativeFieldInfoPtr_currentEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, "currentEnum");
				Evidence.EvidenceEnumerator.NativeFieldInfoPtr_hostEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, "hostEnum");
				Evidence.EvidenceEnumerator.NativeFieldInfoPtr_assemblyEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, "assemblyEnum");
				Evidence.EvidenceEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, 100670992);
				Evidence.EvidenceEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, 100670993);
				Evidence.EvidenceEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, 100670994);
				Evidence.EvidenceEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr, 100670995);
			}

			// Token: 0x0600554C RID: 21836 RVA: 0x0017E598 File Offset: 0x0017C798
			[CallerCount(0)]
			public unsafe EvidenceEnumerator(IEnumerator hostenum, IEnumerator assemblyenum)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Evidence.EvidenceEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hostenum);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyenum);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.EvidenceEnumerator.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600554D RID: 21837 RVA: 0x0017E5F8 File Offset: 0x0017C7F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208133, XrefRangeEnd = 208139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.EvidenceEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600554E RID: 21838 RVA: 0x0017E634 File Offset: 0x0017C834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208139, XrefRangeEnd = 208145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.EvidenceEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015E6 RID: 5606
			// (get) Token: 0x0600554F RID: 21839 RVA: 0x0017E668 File Offset: 0x0017C868
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208145, XrefRangeEnd = 208149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evidence.EvidenceEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005550 RID: 21840 RVA: 0x0002048C File Offset: 0x0001E68C
			public EvidenceEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015E3 RID: 5603
			// (get) Token: 0x06005551 RID: 21841 RVA: 0x0017E6A8 File Offset: 0x0017C8A8
			// (set) Token: 0x06005552 RID: 21842 RVA: 0x00020495 File Offset: 0x0001E695
			public unsafe IEnumerator currentEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_currentEnum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_currentEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015E4 RID: 5604
			// (get) Token: 0x06005553 RID: 21843 RVA: 0x0017E6D8 File Offset: 0x0017C8D8
			// (set) Token: 0x06005554 RID: 21844 RVA: 0x000204B4 File Offset: 0x0001E6B4
			public unsafe IEnumerator hostEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_hostEnum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_hostEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015E5 RID: 5605
			// (get) Token: 0x06005555 RID: 21845 RVA: 0x0017E708 File Offset: 0x0017C908
			// (set) Token: 0x06005556 RID: 21846 RVA: 0x000204D3 File Offset: 0x0001E6D3
			public unsafe IEnumerator assemblyEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_assemblyEnum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evidence.EvidenceEnumerator.NativeFieldInfoPtr_assemblyEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044E1 RID: 17633
			private static readonly IntPtr NativeFieldInfoPtr_currentEnum;

			// Token: 0x040044E2 RID: 17634
			private static readonly IntPtr NativeFieldInfoPtr_hostEnum;

			// Token: 0x040044E3 RID: 17635
			private static readonly IntPtr NativeFieldInfoPtr_assemblyEnum;

			// Token: 0x040044E4 RID: 17636
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_IEnumerator_0;

			// Token: 0x040044E5 RID: 17637
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040044E6 RID: 17638
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x040044E7 RID: 17639
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;
		}
	}
}
