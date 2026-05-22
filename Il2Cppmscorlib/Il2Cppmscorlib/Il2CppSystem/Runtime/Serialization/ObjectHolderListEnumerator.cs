using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033A RID: 826
	public class ObjectHolderListEnumerator : Object
	{
		// Token: 0x06003651 RID: 13905 RVA: 0x0010ACD4 File Offset: 0x00108ED4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectHolderListEnumerator()
		{
			Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectHolderListEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr);
			ObjectHolderListEnumerator.NativeFieldInfoPtr_m_isFixupEnumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_isFixupEnumerator");
			ObjectHolderListEnumerator.NativeFieldInfoPtr_m_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_list");
			ObjectHolderListEnumerator.NativeFieldInfoPtr_m_startingVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_startingVersion");
			ObjectHolderListEnumerator.NativeFieldInfoPtr_m_currPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, "m_currPos");
			ObjectHolderListEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ObjectHolderList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, 100671751);
			ObjectHolderListEnumerator.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, 100671752);
			ObjectHolderListEnumerator.NativeMethodInfoPtr_get_Current_Internal_get_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr, 100671753);
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x0010AD90 File Offset: 0x00108F90
		[CallerCount(0)]
		public unsafe ObjectHolderListEnumerator(ObjectHolderList list, bool isFixupEnumerator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectHolderListEnumerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFixupEnumerator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderListEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ObjectHolderList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x0010ADEC File Offset: 0x00108FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214298, RefRangeEnd = 214299, XrefRangeStart = 214298, XrefRangeEnd = 214298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderListEnumerator.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06003654 RID: 13908 RVA: 0x0010AE28 File Offset: 0x00109028
		public unsafe ObjectHolder Current
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 214299, RefRangeEnd = 214300, XrefRangeStart = 214299, XrefRangeEnd = 214299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectHolderListEnumerator.NativeMethodInfoPtr_get_Current_Internal_get_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolder>(intPtr3) : null;
			}
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x0001337A File Offset: 0x0001157A
		public ObjectHolderListEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06003656 RID: 13910 RVA: 0x0010AE68 File Offset: 0x00109068
		// (set) Token: 0x06003657 RID: 13911 RVA: 0x00013383 File Offset: 0x00011583
		public unsafe bool m_isFixupEnumerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_isFixupEnumerator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_isFixupEnumerator)) = value;
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06003658 RID: 13912 RVA: 0x0010AE90 File Offset: 0x00109090
		// (set) Token: 0x06003659 RID: 13913 RVA: 0x0001339E File Offset: 0x0001159E
		public unsafe ObjectHolderList m_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectHolderList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x0600365A RID: 13914 RVA: 0x0010AEC0 File Offset: 0x001090C0
		// (set) Token: 0x0600365B RID: 13915 RVA: 0x000133BD File Offset: 0x000115BD
		public unsafe int m_startingVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_startingVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_startingVersion)) = value;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x0600365C RID: 13916 RVA: 0x0010AEE8 File Offset: 0x001090E8
		// (set) Token: 0x0600365D RID: 13917 RVA: 0x000133D8 File Offset: 0x000115D8
		public unsafe int m_currPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_currPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectHolderListEnumerator.NativeFieldInfoPtr_m_currPos)) = value;
			}
		}

		// Token: 0x04002DE1 RID: 11745
		private static readonly IntPtr NativeFieldInfoPtr_m_isFixupEnumerator;

		// Token: 0x04002DE2 RID: 11746
		private static readonly IntPtr NativeFieldInfoPtr_m_list;

		// Token: 0x04002DE3 RID: 11747
		private static readonly IntPtr NativeFieldInfoPtr_m_startingVersion;

		// Token: 0x04002DE4 RID: 11748
		private static readonly IntPtr NativeFieldInfoPtr_m_currPos;

		// Token: 0x04002DE5 RID: 11749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ObjectHolderList_Boolean_0;

		// Token: 0x04002DE6 RID: 11750
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Internal_Boolean_0;

		// Token: 0x04002DE7 RID: 11751
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_get_ObjectHolder_0;
	}
}
