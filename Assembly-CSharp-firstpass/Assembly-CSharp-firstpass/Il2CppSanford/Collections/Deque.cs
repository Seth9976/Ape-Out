using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppSanford.Collections
{
	// Token: 0x020001D6 RID: 470
	[Serializable]
	public class Deque : Object
	{
		// Token: 0x0600175F RID: 5983 RVA: 0x0006946C File Offset: 0x0006766C
		// Note: this type is marked as 'beforefieldinit'.
		static Deque()
		{
			Il2CppClassPointerStore<Deque>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections", "Deque");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Deque>.NativeClassPtr);
			Deque.NativeFieldInfoPtr_front = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque>.NativeClassPtr, "front");
			Deque.NativeFieldInfoPtr_back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque>.NativeClassPtr, "back");
			Deque.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque>.NativeClassPtr, "count");
			Deque.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque>.NativeClassPtr, "version");
			Deque.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666625);
			Deque.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666626);
			Deque.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666627);
			Deque.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666628);
			Deque.NativeMethodInfoPtr_PushFront_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666629);
			Deque.NativeMethodInfoPtr_PushBack_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666630);
			Deque.NativeMethodInfoPtr_PopFront_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666631);
			Deque.NativeMethodInfoPtr_PopBack_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666632);
			Deque.NativeMethodInfoPtr_PeekFront_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666633);
			Deque.NativeMethodInfoPtr_PeekBack_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666634);
			Deque.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666635);
			Deque.NativeMethodInfoPtr_Synchronized_Public_Static_Deque_Deque_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666636);
			Deque.NativeMethodInfoPtr_AssertValid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666637);
			Deque.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666638);
			Deque.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666639);
			Deque.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666640);
			Deque.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666641);
			Deque.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666642);
			Deque.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque>.NativeClassPtr, 100666643);
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00069668 File Offset: 0x00067868
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Deque()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Deque>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x000696A4 File Offset: 0x000678A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18708, RefRangeEnd = 18709, XrefRangeStart = 18692, XrefRangeEnd = 18708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Deque(ICollection col)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Deque>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.NativeMethodInfoPtr__ctor_Public_Void_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x000696F0 File Offset: 0x000678F0
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x0006972C File Offset: 0x0006792C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18709, XrefRangeEnd = 18722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00069784 File Offset: 0x00067984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18722, XrefRangeEnd = 18725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PushFront(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_PushFront_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x000697D4 File Offset: 0x000679D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18725, XrefRangeEnd = 18728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PushBack(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_PushBack_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00069824 File Offset: 0x00067A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18728, XrefRangeEnd = 18731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object PopFront()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_PopFront_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00069870 File Offset: 0x00067A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18731, XrefRangeEnd = 18734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object PopBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_PopBack_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x000698BC File Offset: 0x00067ABC
		[CallerCount(0)]
		public unsafe virtual Object PeekFront()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_PeekFront_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00069908 File Offset: 0x00067B08
		[CallerCount(0)]
		public unsafe virtual Object PeekBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_PeekBack_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00069954 File Offset: 0x00067B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18734, XrefRangeEnd = 18754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Object> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x000699A0 File Offset: 0x00067BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18754, XrefRangeEnd = 18757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Deque Synchronized(Deque deque)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deque);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.NativeMethodInfoPtr_Synchronized_Public_Static_Deque_Deque_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Deque>(intPtr3) : null;
			}
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x000699E4 File Offset: 0x00067BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18757, XrefRangeEnd = 18758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssertValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.NativeMethodInfoPtr_AssertValid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x00069A18 File Offset: 0x00067C18
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x00069A60 File Offset: 0x00067C60
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00069AA8 File Offset: 0x00067CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18758, XrefRangeEnd = 18773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x00069B04 File Offset: 0x00067D04
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00069B50 File Offset: 0x00067D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18773, XrefRangeEnd = 18776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00069B9C File Offset: 0x00067D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18776, XrefRangeEnd = 18780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x00009627 File Offset: 0x00007827
		public Deque(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x00069BE8 File Offset: 0x00067DE8
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x00009630 File Offset: 0x00007830
		public unsafe Deque.Node front
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.NativeFieldInfoPtr_front);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque.Node>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.NativeFieldInfoPtr_front), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x00069C18 File Offset: 0x00067E18
		// (set) Token: 0x06001777 RID: 6007 RVA: 0x0000964F File Offset: 0x0000784F
		public unsafe Deque.Node back
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.NativeFieldInfoPtr_back);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque.Node>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.NativeFieldInfoPtr_back), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x00069C48 File Offset: 0x00067E48
		// (set) Token: 0x06001779 RID: 6009 RVA: 0x0000966E File Offset: 0x0000786E
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x00069C70 File Offset: 0x00067E70
		// (set) Token: 0x0600177B RID: 6011 RVA: 0x00009689 File Offset: 0x00007889
		public unsafe long version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x040018CC RID: 6348
		private static readonly IntPtr NativeFieldInfoPtr_front;

		// Token: 0x040018CD RID: 6349
		private static readonly IntPtr NativeFieldInfoPtr_back;

		// Token: 0x040018CE RID: 6350
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040018CF RID: 6351
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040018D0 RID: 6352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ICollection_0;

		// Token: 0x040018D2 RID: 6354
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x040018D3 RID: 6355
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x040018D4 RID: 6356
		private static readonly IntPtr NativeMethodInfoPtr_PushFront_Public_Virtual_New_Void_Object_0;

		// Token: 0x040018D5 RID: 6357
		private static readonly IntPtr NativeMethodInfoPtr_PushBack_Public_Virtual_New_Void_Object_0;

		// Token: 0x040018D6 RID: 6358
		private static readonly IntPtr NativeMethodInfoPtr_PopFront_Public_Virtual_New_Object_0;

		// Token: 0x040018D7 RID: 6359
		private static readonly IntPtr NativeMethodInfoPtr_PopBack_Public_Virtual_New_Object_0;

		// Token: 0x040018D8 RID: 6360
		private static readonly IntPtr NativeMethodInfoPtr_PeekFront_Public_Virtual_New_Object_0;

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeMethodInfoPtr_PeekBack_Public_Virtual_New_Object_0;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_Deque_Deque_0;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeMethodInfoPtr_AssertValid_Private_Void_0;

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

		// Token: 0x040018E1 RID: 6369
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x040018E2 RID: 6370
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x02000259 RID: 601
		[Serializable]
		public class Node : Object
		{
			// Token: 0x060020D1 RID: 8401 RVA: 0x0008F3E0 File Offset: 0x0008D5E0
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<Deque.Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Deque>.NativeClassPtr, "Node");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Deque.Node>.NativeClassPtr);
				Deque.Node.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque.Node>.NativeClassPtr, "value");
				Deque.Node.NativeFieldInfoPtr_previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque.Node>.NativeClassPtr, "previous");
				Deque.Node.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque.Node>.NativeClassPtr, "next");
				Deque.Node.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.Node>.NativeClassPtr, 100666644);
				Deque.Node.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.Node>.NativeClassPtr, 100666645);
				Deque.Node.NativeMethodInfoPtr_get_Previous_Public_get_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.Node>.NativeClassPtr, 100666646);
				Deque.Node.NativeMethodInfoPtr_set_Previous_Public_set_Void_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.Node>.NativeClassPtr, 100666647);
				Deque.Node.NativeMethodInfoPtr_get_Next_Public_get_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.Node>.NativeClassPtr, 100666648);
				Deque.Node.NativeMethodInfoPtr_set_Next_Public_set_Void_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.Node>.NativeClassPtr, 100666649);
			}

			// Token: 0x060020D2 RID: 8402 RVA: 0x0008F4C0 File Offset: 0x0008D6C0
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node(Object value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Deque.Node>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.Node.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000686 RID: 1670
			// (get) Token: 0x060020D3 RID: 8403 RVA: 0x0008F50C File Offset: 0x0008D70C
			public unsafe Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.Node.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000687 RID: 1671
			// (get) Token: 0x060020D4 RID: 8404 RVA: 0x0008F54C File Offset: 0x0008D74C
			// (set) Token: 0x060020D5 RID: 8405 RVA: 0x0008F58C File Offset: 0x0008D78C
			public unsafe Deque.Node Previous
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.Node.NativeMethodInfoPtr_get_Previous_Public_get_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Deque.Node>(intPtr3) : null;
				}
				[CallerCount(58)]
				[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.Node.NativeMethodInfoPtr_set_Previous_Public_set_Void_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000688 RID: 1672
			// (get) Token: 0x060020D6 RID: 8406 RVA: 0x0008F5D0 File Offset: 0x0008D7D0
			// (set) Token: 0x060020D7 RID: 8407 RVA: 0x0008F610 File Offset: 0x0008D810
			public unsafe Deque.Node Next
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.Node.NativeMethodInfoPtr_get_Next_Public_get_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Deque.Node>(intPtr3) : null;
				}
				[CallerCount(33)]
				[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.Node.NativeMethodInfoPtr_set_Next_Public_set_Void_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060020D8 RID: 8408 RVA: 0x0000C274 File Offset: 0x0000A474
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000683 RID: 1667
			// (get) Token: 0x060020D9 RID: 8409 RVA: 0x0008F654 File Offset: 0x0008D854
			// (set) Token: 0x060020DA RID: 8410 RVA: 0x0000C27D File Offset: 0x0000A47D
			public unsafe Object value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.Node.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.Node.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000684 RID: 1668
			// (get) Token: 0x060020DB RID: 8411 RVA: 0x0008F684 File Offset: 0x0008D884
			// (set) Token: 0x060020DC RID: 8412 RVA: 0x0000C29C File Offset: 0x0000A49C
			public unsafe Deque.Node previous
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.Node.NativeFieldInfoPtr_previous);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.Node.NativeFieldInfoPtr_previous), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000685 RID: 1669
			// (get) Token: 0x060020DD RID: 8413 RVA: 0x0008F6B4 File Offset: 0x0008D8B4
			// (set) Token: 0x060020DE RID: 8414 RVA: 0x0000C2BB File Offset: 0x0000A4BB
			public unsafe Deque.Node next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.Node.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.Node.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400208B RID: 8331
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400208C RID: 8332
			private static readonly IntPtr NativeFieldInfoPtr_previous;

			// Token: 0x0400208D RID: 8333
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x0400208E RID: 8334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

			// Token: 0x0400208F RID: 8335
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

			// Token: 0x04002090 RID: 8336
			private static readonly IntPtr NativeMethodInfoPtr_get_Previous_Public_get_Node_0;

			// Token: 0x04002091 RID: 8337
			private static readonly IntPtr NativeMethodInfoPtr_set_Previous_Public_set_Void_Node_0;

			// Token: 0x04002092 RID: 8338
			private static readonly IntPtr NativeMethodInfoPtr_get_Next_Public_get_Node_0;

			// Token: 0x04002093 RID: 8339
			private static readonly IntPtr NativeMethodInfoPtr_set_Next_Public_set_Void_Node_0;
		}

		// Token: 0x0200025A RID: 602
		[Serializable]
		public class DequeEnumerator : Object
		{
			// Token: 0x060020DF RID: 8415 RVA: 0x0008F6E4 File Offset: 0x0008D8E4
			// Note: this type is marked as 'beforefieldinit'.
			static DequeEnumerator()
			{
				Il2CppClassPointerStore<Deque.DequeEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Deque>.NativeClassPtr, "DequeEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Deque.DequeEnumerator>.NativeClassPtr);
				Deque.DequeEnumerator.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque.DequeEnumerator>.NativeClassPtr, "owner");
				Deque.DequeEnumerator.NativeFieldInfoPtr_currentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque.DequeEnumerator>.NativeClassPtr, "currentNode");
				Deque.DequeEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque.DequeEnumerator>.NativeClassPtr, "current");
				Deque.DequeEnumerator.NativeFieldInfoPtr_moveResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque.DequeEnumerator>.NativeClassPtr, "moveResult");
				Deque.DequeEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque.DequeEnumerator>.NativeClassPtr, "version");
				Deque.DequeEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Deque_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.DequeEnumerator>.NativeClassPtr, 100666650);
				Deque.DequeEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.DequeEnumerator>.NativeClassPtr, 100666651);
				Deque.DequeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.DequeEnumerator>.NativeClassPtr, 100666652);
				Deque.DequeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.DequeEnumerator>.NativeClassPtr, 100666653);
			}

			// Token: 0x060020E0 RID: 8416 RVA: 0x0008F7C4 File Offset: 0x0008D9C4
			[CallerCount(0)]
			public unsafe DequeEnumerator(Deque owner)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Deque.DequeEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.DequeEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Deque_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020E1 RID: 8417 RVA: 0x0008F810 File Offset: 0x0008DA10
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.DequeEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x060020E2 RID: 8418 RVA: 0x0008F844 File Offset: 0x0008DA44
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.DequeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020E3 RID: 8419 RVA: 0x0008F884 File Offset: 0x0008DA84
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.DequeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060020E4 RID: 8420 RVA: 0x0000C2DA File Offset: 0x0000A4DA
			public DequeEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000689 RID: 1673
			// (get) Token: 0x060020E5 RID: 8421 RVA: 0x0008F8C0 File Offset: 0x0008DAC0
			// (set) Token: 0x060020E6 RID: 8422 RVA: 0x0000C2E3 File Offset: 0x0000A4E3
			public unsafe Deque owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.DequeEnumerator.NativeFieldInfoPtr_owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.DequeEnumerator.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068A RID: 1674
			// (get) Token: 0x060020E7 RID: 8423 RVA: 0x0008F8F0 File Offset: 0x0008DAF0
			// (set) Token: 0x060020E8 RID: 8424 RVA: 0x0000C302 File Offset: 0x0000A502
			public unsafe Deque.Node currentNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.DequeEnumerator.NativeFieldInfoPtr_currentNode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.DequeEnumerator.NativeFieldInfoPtr_currentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068B RID: 1675
			// (get) Token: 0x060020E9 RID: 8425 RVA: 0x0008F920 File Offset: 0x0008DB20
			// (set) Token: 0x060020EA RID: 8426 RVA: 0x0000C321 File Offset: 0x0000A521
			public unsafe Object current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.DequeEnumerator.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.DequeEnumerator.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068C RID: 1676
			// (get) Token: 0x060020EB RID: 8427 RVA: 0x0008F950 File Offset: 0x0008DB50
			// (set) Token: 0x060020EC RID: 8428 RVA: 0x0000C340 File Offset: 0x0000A540
			public unsafe bool moveResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.DequeEnumerator.NativeFieldInfoPtr_moveResult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.DequeEnumerator.NativeFieldInfoPtr_moveResult)) = value;
				}
			}

			// Token: 0x1700068D RID: 1677
			// (get) Token: 0x060020ED RID: 8429 RVA: 0x0008F978 File Offset: 0x0008DB78
			// (set) Token: 0x060020EE RID: 8430 RVA: 0x0000C35B File Offset: 0x0000A55B
			public unsafe long version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.DequeEnumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.DequeEnumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x04002094 RID: 8340
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x04002095 RID: 8341
			private static readonly IntPtr NativeFieldInfoPtr_currentNode;

			// Token: 0x04002096 RID: 8342
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x04002097 RID: 8343
			private static readonly IntPtr NativeFieldInfoPtr_moveResult;

			// Token: 0x04002098 RID: 8344
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x04002099 RID: 8345
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Deque_0;

			// Token: 0x0400209A RID: 8346
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400209B RID: 8347
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x0400209C RID: 8348
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;
		}

		// Token: 0x0200025B RID: 603
		[Serializable]
		public class SynchronizedDeque : Deque
		{
			// Token: 0x060020EF RID: 8431 RVA: 0x0008F9A0 File Offset: 0x0008DBA0
			// Note: this type is marked as 'beforefieldinit'.
			static SynchronizedDeque()
			{
				Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Deque>.NativeClassPtr, "SynchronizedDeque");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr);
				Deque.SynchronizedDeque.NativeFieldInfoPtr_deque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, "deque");
				Deque.SynchronizedDeque.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, "root");
				Deque.SynchronizedDeque.NativeMethodInfoPtr__ctor_Public_Void_Deque_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666654);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666655);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666656);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_PushFront_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666657);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_PushBack_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666658);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_PopFront_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666659);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_PopBack_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666660);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_PeekFront_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666661);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_PeekBack_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666662);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666663);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666664);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666665);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666666);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666667);
				Deque.SynchronizedDeque.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr, 100666668);
			}

			// Token: 0x060020F0 RID: 8432 RVA: 0x0008FB20 File Offset: 0x0008DD20
			[CallerCount(0)]
			public unsafe SynchronizedDeque(Deque deque)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Deque.SynchronizedDeque>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(deque);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque.SynchronizedDeque.NativeMethodInfoPtr__ctor_Public_Void_Deque_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020F1 RID: 8433 RVA: 0x0008FB6C File Offset: 0x0008DD6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18653, XrefRangeEnd = 18656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020F2 RID: 8434 RVA: 0x0008FBA8 File Offset: 0x0008DDA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18656, XrefRangeEnd = 18659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Contains(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060020F3 RID: 8435 RVA: 0x0008FC00 File Offset: 0x0008DE00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18659, XrefRangeEnd = 18662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void PushFront(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_PushFront_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020F4 RID: 8436 RVA: 0x0008FC50 File Offset: 0x0008DE50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18662, XrefRangeEnd = 18665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void PushBack(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_PushBack_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020F5 RID: 8437 RVA: 0x0008FCA0 File Offset: 0x0008DEA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18665, XrefRangeEnd = 18668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object PopFront()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_PopFront_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060020F6 RID: 8438 RVA: 0x0008FCEC File Offset: 0x0008DEEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18668, XrefRangeEnd = 18671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object PopBack()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_PopBack_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060020F7 RID: 8439 RVA: 0x0008FD38 File Offset: 0x0008DF38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18671, XrefRangeEnd = 18674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object PeekFront()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_PeekFront_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060020F8 RID: 8440 RVA: 0x0008FD84 File Offset: 0x0008DF84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18674, XrefRangeEnd = 18677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object PeekBack()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_PeekBack_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060020F9 RID: 8441 RVA: 0x0008FDD0 File Offset: 0x0008DFD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18677, XrefRangeEnd = 18680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Il2CppReferenceArray<Object> ToArray()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}

			// Token: 0x060020FA RID: 8442 RVA: 0x0008FE1C File Offset: 0x0008E01C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18680, XrefRangeEnd = 18683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060020FB RID: 8443 RVA: 0x0008FE68 File Offset: 0x0008E068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18683, XrefRangeEnd = 18686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void CopyTo(Array array, int index)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020FC RID: 8444 RVA: 0x0008FEC4 File Offset: 0x0008E0C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18686, XrefRangeEnd = 18689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x060020FD RID: 8445 RVA: 0x0008FF10 File Offset: 0x0008E110
			public unsafe override int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18689, XrefRangeEnd = 18692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x060020FE RID: 8446 RVA: 0x0008FF58 File Offset: 0x0008E158
			public unsafe override bool IsSynchronized
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque.SynchronizedDeque.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060020FF RID: 8447 RVA: 0x0000C376 File Offset: 0x0000A576
			public SynchronizedDeque(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x06002100 RID: 8448 RVA: 0x0008FFA0 File Offset: 0x0008E1A0
			// (set) Token: 0x06002101 RID: 8449 RVA: 0x0000C37F File Offset: 0x0000A57F
			public unsafe Deque deque
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.SynchronizedDeque.NativeFieldInfoPtr_deque);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.SynchronizedDeque.NativeFieldInfoPtr_deque), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x06002102 RID: 8450 RVA: 0x0008FFD0 File Offset: 0x0008E1D0
			// (set) Token: 0x06002103 RID: 8451 RVA: 0x0000C39E File Offset: 0x0000A59E
			public unsafe Object root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.SynchronizedDeque.NativeFieldInfoPtr_root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque.SynchronizedDeque.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400209D RID: 8349
			private static readonly IntPtr NativeFieldInfoPtr_deque;

			// Token: 0x0400209E RID: 8350
			private static readonly IntPtr NativeFieldInfoPtr_root;

			// Token: 0x0400209F RID: 8351
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Deque_0;

			// Token: 0x040020A0 RID: 8352
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

			// Token: 0x040020A1 RID: 8353
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_Object_0;

			// Token: 0x040020A2 RID: 8354
			private static readonly IntPtr NativeMethodInfoPtr_PushFront_Public_Virtual_Void_Object_0;

			// Token: 0x040020A3 RID: 8355
			private static readonly IntPtr NativeMethodInfoPtr_PushBack_Public_Virtual_Void_Object_0;

			// Token: 0x040020A4 RID: 8356
			private static readonly IntPtr NativeMethodInfoPtr_PopFront_Public_Virtual_Object_0;

			// Token: 0x040020A5 RID: 8357
			private static readonly IntPtr NativeMethodInfoPtr_PopBack_Public_Virtual_Object_0;

			// Token: 0x040020A6 RID: 8358
			private static readonly IntPtr NativeMethodInfoPtr_PeekFront_Public_Virtual_Object_0;

			// Token: 0x040020A7 RID: 8359
			private static readonly IntPtr NativeMethodInfoPtr_PeekBack_Public_Virtual_Object_0;

			// Token: 0x040020A8 RID: 8360
			private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppReferenceArray_1_Object_0;

			// Token: 0x040020A9 RID: 8361
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

			// Token: 0x040020AA RID: 8362
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0;

			// Token: 0x040020AB RID: 8363
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;

			// Token: 0x040020AC RID: 8364
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

			// Token: 0x040020AD RID: 8365
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0;
		}
	}
}
