using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Collections.Immutable
{
	// Token: 0x020001DE RID: 478
	public class ArrayList : Object
	{
		// Token: 0x0600181F RID: 6175 RVA: 0x0006C610 File Offset: 0x0006A810
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayList()
		{
			Il2CppClassPointerStore<ArrayList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Immutable", "ArrayList");
			ArrayList.NativeFieldInfoPtr_TreePoolHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "TreePoolHeight");
			ArrayList.NativeFieldInfoPtr_DefaultCapacityHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "DefaultCapacityHeight");
			ArrayList.NativeFieldInfoPtr_TreePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "TreePool");
			ArrayList.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "count");
			ArrayList.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, "root");
			ArrayList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666799);
			ArrayList.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666800);
			ArrayList.NativeMethodInfoPtr__ctor_Private_Void_IAvlNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666801);
			ArrayList.NativeMethodInfoPtr_Add_Public_ArrayList_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666802);
			ArrayList.NativeMethodInfoPtr_Contains_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666803);
			ArrayList.NativeMethodInfoPtr_IndexOf_Public_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666804);
			ArrayList.NativeMethodInfoPtr_Insert_Public_ArrayList_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666805);
			ArrayList.NativeMethodInfoPtr_Remove_Public_ArrayList_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666806);
			ArrayList.NativeMethodInfoPtr_RemoveAt_Public_ArrayList_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666807);
			ArrayList.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666808);
			ArrayList.NativeMethodInfoPtr_SetValue_Public_ArrayList_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666809);
			ArrayList.NativeMethodInfoPtr_CollectionToTree_Private_IAvlNode_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666810);
			ArrayList.NativeMethodInfoPtr_EnlargeTree_Private_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666811);
			ArrayList.NativeMethodInfoPtr_GetValue_Private_Object_Int32_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666812);
			ArrayList.NativeMethodInfoPtr_SetValue_Private_IAvlNode_Int32_Object_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666813);
			ArrayList.NativeMethodInfoPtr_GetSubTree_Private_Static_IAvlNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666814);
			ArrayList.NativeMethodInfoPtr_Insert_Private_IAvlNode_Int32_Object_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666815);
			ArrayList.NativeMethodInfoPtr_RemoveAt_Private_IAvlNode_Int32_IAvlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666816);
			ArrayList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666817);
			ArrayList.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayList>.NativeClassPtr, 100666818);
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0006C82C File Offset: 0x0006AA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19496, XrefRangeEnd = 19500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x0006C868 File Offset: 0x0006AA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19500, XrefRangeEnd = 19520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList(ICollection collection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0006C8B4 File Offset: 0x0006AAB4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 19461, RefRangeEnd = 19470, XrefRangeStart = 19461, XrefRangeEnd = 19470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList(IAvlNode root, int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayList>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr__ctor_Private_Void_IAvlNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0006C910 File Offset: 0x0006AB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19520, XrefRangeEnd = 19542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_Add_Public_ArrayList_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0006C960 File Offset: 0x0006AB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19542, XrefRangeEnd = 19543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_Contains_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0006C9B0 File Offset: 0x0006ABB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19564, RefRangeEnd = 19566, XrefRangeStart = 19543, XrefRangeEnd = 19564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_IndexOf_Public_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0006CA00 File Offset: 0x0006AC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19566, XrefRangeEnd = 19571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList Insert(int index, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_Insert_Public_ArrayList_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x0006CA60 File Offset: 0x0006AC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19571, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList Remove(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_Remove_Public_ArrayList_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0006CAB0 File Offset: 0x0006ACB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19577, XrefRangeEnd = 19582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_RemoveAt_Public_ArrayList_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0006CAFC File Offset: 0x0006ACFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19582, XrefRangeEnd = 19592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_GetValue_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x0006CB48 File Offset: 0x0006AD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19592, XrefRangeEnd = 19597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList SetValue(int index, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_SetValue_Public_ArrayList_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0006CBA8 File Offset: 0x0006ADA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19622, RefRangeEnd = 19625, XrefRangeStart = 19597, XrefRangeEnd = 19622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAvlNode CollectionToTree(IEnumerator enumerator, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_CollectionToTree_Private_IAvlNode_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0006CC08 File Offset: 0x0006AE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19625, XrefRangeEnd = 19636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAvlNode EnlargeTree()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_EnlargeTree_Private_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0006CC48 File Offset: 0x0006AE48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19649, RefRangeEnd = 19652, XrefRangeStart = 19636, XrefRangeEnd = 19649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue(int index, IAvlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_GetValue_Private_Object_Int32_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x0006CCA8 File Offset: 0x0006AEA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 19679, RefRangeEnd = 19684, XrefRangeStart = 19652, XrefRangeEnd = 19679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAvlNode SetValue(int index, Object value, IAvlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_SetValue_Private_IAvlNode_Int32_Object_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0006CD18 File Offset: 0x0006AF18
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 19693, RefRangeEnd = 19698, XrefRangeStart = 19684, XrefRangeEnd = 19693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IAvlNode GetSubTree(int height)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_GetSubTree_Private_Static_IAvlNode_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0006CD58 File Offset: 0x0006AF58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19731, RefRangeEnd = 19734, XrefRangeStart = 19698, XrefRangeEnd = 19731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAvlNode Insert(int index, Object value, IAvlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_Insert_Private_IAvlNode_Int32_Object_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0006CDC8 File Offset: 0x0006AFC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19765, RefRangeEnd = 19769, XrefRangeStart = 19734, XrefRangeEnd = 19765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAvlNode RemoveAt(int index, IAvlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_RemoveAt_Private_IAvlNode_Int32_IAvlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr3) : null;
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x0006CE28 File Offset: 0x0006B028
		public unsafe int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x0006CE64 File Offset: 0x0006B064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19769, XrefRangeEnd = 19777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayList.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x000099E9 File Offset: 0x00007BE9
		public ArrayList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x0006CEA4 File Offset: 0x0006B0A4
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x000099F2 File Offset: 0x00007BF2
		public unsafe static int TreePoolHeight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ArrayList.NativeFieldInfoPtr_TreePoolHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArrayList.NativeFieldInfoPtr_TreePoolHeight, (void*)(&value));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x0006CEC0 File Offset: 0x0006B0C0
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x00009A00 File Offset: 0x00007C00
		public unsafe static int DefaultCapacityHeight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ArrayList.NativeFieldInfoPtr_DefaultCapacityHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArrayList.NativeFieldInfoPtr_DefaultCapacityHeight, (void*)(&value));
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x0006CEDC File Offset: 0x0006B0DC
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x00009A0E File Offset: 0x00007C0E
		public unsafe static IAvlNode TreePool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArrayList.NativeFieldInfoPtr_TreePool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArrayList.NativeFieldInfoPtr_TreePool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x0006CF04 File Offset: 0x0006B104
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x00009A20 File Offset: 0x00007C20
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x0006CF2C File Offset: 0x0006B12C
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x00009A3B File Offset: 0x00007C3B
		public unsafe IAvlNode root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAvlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArrayList.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeFieldInfoPtr_TreePoolHeight;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCapacityHeight;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeFieldInfoPtr_TreePool;

		// Token: 0x0400195E RID: 6494
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x0400195F RID: 6495
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04001960 RID: 6496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001961 RID: 6497
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICollection_0;

		// Token: 0x04001962 RID: 6498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IAvlNode_Int32_0;

		// Token: 0x04001963 RID: 6499
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_ArrayList_Object_0;

		// Token: 0x04001964 RID: 6500
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Object_0;

		// Token: 0x04001965 RID: 6501
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Object_0;

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_ArrayList_Int32_Object_0;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_ArrayList_Object_0;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_ArrayList_Int32_0;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Int32_0;

		// Token: 0x0400196A RID: 6506
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_ArrayList_Int32_Object_0;

		// Token: 0x0400196B RID: 6507
		private static readonly IntPtr NativeMethodInfoPtr_CollectionToTree_Private_IAvlNode_IEnumerator_Int32_0;

		// Token: 0x0400196C RID: 6508
		private static readonly IntPtr NativeMethodInfoPtr_EnlargeTree_Private_IAvlNode_0;

		// Token: 0x0400196D RID: 6509
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Private_Object_Int32_IAvlNode_0;

		// Token: 0x0400196E RID: 6510
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Private_IAvlNode_Int32_Object_IAvlNode_0;

		// Token: 0x0400196F RID: 6511
		private static readonly IntPtr NativeMethodInfoPtr_GetSubTree_Private_Static_IAvlNode_Int32_0;

		// Token: 0x04001970 RID: 6512
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Private_IAvlNode_Int32_Object_IAvlNode_0;

		// Token: 0x04001971 RID: 6513
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Private_IAvlNode_Int32_IAvlNode_0;

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;
	}
}
