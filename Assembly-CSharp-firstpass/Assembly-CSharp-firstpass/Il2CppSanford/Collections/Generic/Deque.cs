using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSanford.Collections.Generic
{
	// Token: 0x020001E5 RID: 485
	[Serializable]
	public class Deque<T> : Object
	{
		// Token: 0x060018AD RID: 6317 RVA: 0x0006E9A0 File Offset: 0x0006CBA0
		// Note: this type is marked as 'beforefieldinit'.
		static Deque()
		{
			Il2CppClassPointerStore<Deque<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Collections.Generic", "Deque`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr);
			Deque<T>.NativeFieldInfoPtr_front = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, "front");
			Deque<T>.NativeFieldInfoPtr_back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, "back");
			Deque<T>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, "count");
			Deque<T>.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, "version");
			Deque<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666890);
			Deque<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666891);
			Deque<T>.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666892);
			Deque<T>.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666893);
			Deque<T>.NativeMethodInfoPtr_PushFront_Public_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666894);
			Deque<T>.NativeMethodInfoPtr_PushBack_Public_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666895);
			Deque<T>.NativeMethodInfoPtr_PopFront_Public_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666896);
			Deque<T>.NativeMethodInfoPtr_PopBack_Public_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666897);
			Deque<T>.NativeMethodInfoPtr_PeekFront_Public_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666898);
			Deque<T>.NativeMethodInfoPtr_PeekBack_Public_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666899);
			Deque<T>.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666900);
			Deque<T>.NativeMethodInfoPtr_Synchronized_Public_Static_Deque_1_T_Deque_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666901);
			Deque<T>.NativeMethodInfoPtr_AssertValid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666902);
			Deque<T>.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666903);
			Deque<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666904);
			Deque<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666905);
			Deque<T>.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666906);
			Deque<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666907);
			Deque<T>.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666908);
			Deque<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, 100666909);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0006EBEC File Offset: 0x0006CDEC
		[CallerCount(0)]
		public unsafe Deque()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0006EC28 File Offset: 0x0006CE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20210, XrefRangeEnd = 20223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Deque(IEnumerable<T> collection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0006EC74 File Offset: 0x0006CE74
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0006ECB0 File Offset: 0x0006CEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20223, XrefRangeEnd = 20233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(T obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref obj;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0006ED54 File Offset: 0x0006CF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20233, XrefRangeEnd = 20235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PushFront(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_PushFront_Public_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0006EDEC File Offset: 0x0006CFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20235, XrefRangeEnd = 20237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PushBack(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					if (!(t is string))
					{
						ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr3) != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref item;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_PushBack_Public_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0006EE84 File Offset: 0x0006D084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20237, XrefRangeEnd = 20239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T PopFront()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_PopFront_Public_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0006EEC8 File Offset: 0x0006D0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20239, XrefRangeEnd = 20241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T PopBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_PopBack_Public_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0006EF0C File Offset: 0x0006D10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20241, XrefRangeEnd = 20248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T PeekFront()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_PeekFront_Public_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0006EF50 File Offset: 0x0006D150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20248, XrefRangeEnd = 20255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T PeekBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_PeekBack_Public_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0006EF94 File Offset: 0x0006D194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20255, XrefRangeEnd = 20269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppArrayBase<T> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppArrayBase_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0006EFD8 File Offset: 0x0006D1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20269, XrefRangeEnd = 20274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Deque<T> Synchronized(Deque<T> deque)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deque);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.NativeMethodInfoPtr_Synchronized_Public_Static_Deque_1_T_Deque_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Deque<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0006F01C File Offset: 0x0006D21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20274, XrefRangeEnd = 20275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssertValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.NativeMethodInfoPtr_AssertValid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060018BB RID: 6331 RVA: 0x0006F050 File Offset: 0x0006D250
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x0006F098 File Offset: 0x0006D298
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0006F0E0 File Offset: 0x0006D2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20275, XrefRangeEnd = 20288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x0006F13C File Offset: 0x0006D33C
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(397)]
			[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0006F188 File Offset: 0x0006D388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20288, XrefRangeEnd = 20290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0006F1C8 File Offset: 0x0006D3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20290, XrefRangeEnd = 20292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0006F214 File Offset: 0x0006D414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x00009D3D File Offset: 0x00007F3D
		public Deque(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x0006F260 File Offset: 0x0006D460
		// (set) Token: 0x060018C4 RID: 6340 RVA: 0x00009D46 File Offset: 0x00007F46
		public unsafe Deque<T>.Node front
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.NativeFieldInfoPtr_front);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque<T>.Node>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.NativeFieldInfoPtr_front), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0006F290 File Offset: 0x0006D490
		// (set) Token: 0x060018C6 RID: 6342 RVA: 0x00009D65 File Offset: 0x00007F65
		public unsafe Deque<T>.Node back
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.NativeFieldInfoPtr_back);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque<T>.Node>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.NativeFieldInfoPtr_back), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x0006F2C0 File Offset: 0x0006D4C0
		// (set) Token: 0x060018C8 RID: 6344 RVA: 0x00009D84 File Offset: 0x00007F84
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0006F2E8 File Offset: 0x0006D4E8
		// (set) Token: 0x060018CA RID: 6346 RVA: 0x00009D9F File Offset: 0x00007F9F
		public unsafe long version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeFieldInfoPtr_front;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeFieldInfoPtr_back;

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_New_Boolean_T_0;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeMethodInfoPtr_PushFront_Public_Virtual_New_Void_T_0;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeMethodInfoPtr_PushBack_Public_Virtual_New_Void_T_0;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeMethodInfoPtr_PopFront_Public_Virtual_New_T_0;

		// Token: 0x040019C9 RID: 6601
		private static readonly IntPtr NativeMethodInfoPtr_PopBack_Public_Virtual_New_T_0;

		// Token: 0x040019CA RID: 6602
		private static readonly IntPtr NativeMethodInfoPtr_PeekFront_Public_Virtual_New_T_0;

		// Token: 0x040019CB RID: 6603
		private static readonly IntPtr NativeMethodInfoPtr_PeekBack_Public_Virtual_New_T_0;

		// Token: 0x040019CC RID: 6604
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_New_Il2CppArrayBase_1_T_0;

		// Token: 0x040019CD RID: 6605
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_Deque_1_T_Deque_1_T_0;

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeMethodInfoPtr_AssertValid_Private_Void_0;

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_1_T_0;

		// Token: 0x02000266 RID: 614
		[Serializable]
		public class Enumerator : Object
		{
			// Token: 0x06002180 RID: 8576 RVA: 0x00091B5C File Offset: 0x0008FD5C
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr);
				Deque<T>.Enumerator.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr, "owner");
				Deque<T>.Enumerator.NativeFieldInfoPtr_currentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr, "currentNode");
				Deque<T>.Enumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr, "current");
				Deque<T>.Enumerator.NativeFieldInfoPtr_moveResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr, "moveResult");
				Deque<T>.Enumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr, "version");
				Deque<T>.Enumerator.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr, "disposed");
				Deque<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_Deque_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr, 100666910);
				Deque<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr, 100666911);
				Deque<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr, 100666912);
				Deque<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr, 100666913);
				Deque<T>.Enumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr, 100666914);
				Deque<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr, 100666915);
			}

			// Token: 0x06002181 RID: 8577 RVA: 0x00091CB4 File Offset: 0x0008FEB4
			[CallerCount(0)]
			public unsafe Enumerator(Deque<T> owner)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Deque<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_Deque_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002182 RID: 8578 RVA: 0x00091D00 File Offset: 0x0008FF00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20167, XrefRangeEnd = 20168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006C4 RID: 1732
			// (get) Token: 0x06002183 RID: 8579 RVA: 0x00091D34 File Offset: 0x0008FF34
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002184 RID: 8580 RVA: 0x00091D74 File Offset: 0x0008FF74
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006C5 RID: 1733
			// (get) Token: 0x06002185 RID: 8581 RVA: 0x00091DB0 File Offset: 0x0008FFB0
			public unsafe virtual T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.Enumerator.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06002186 RID: 8582 RVA: 0x00091DEC File Offset: 0x0008FFEC
			[CallerCount(0)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002187 RID: 8583 RVA: 0x0000C6F3 File Offset: 0x0000A8F3
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006BE RID: 1726
			// (get) Token: 0x06002188 RID: 8584 RVA: 0x00091E20 File Offset: 0x00090020
			// (set) Token: 0x06002189 RID: 8585 RVA: 0x0000C6FC File Offset: 0x0000A8FC
			public unsafe Deque<T> owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Enumerator.NativeFieldInfoPtr_owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Enumerator.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006BF RID: 1727
			// (get) Token: 0x0600218A RID: 8586 RVA: 0x00091E50 File Offset: 0x00090050
			// (set) Token: 0x0600218B RID: 8587 RVA: 0x0000C71B File Offset: 0x0000A91B
			public unsafe Deque<T>.Node currentNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Enumerator.NativeFieldInfoPtr_currentNode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque<T>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Enumerator.NativeFieldInfoPtr_currentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C0 RID: 1728
			// (get) Token: 0x0600218C RID: 8588 RVA: 0x00091E80 File Offset: 0x00090080
			// (set) Token: 0x0600218D RID: 8589 RVA: 0x00091EA8 File Offset: 0x000900A8
			public unsafe T current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Enumerator.NativeFieldInfoPtr_current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Enumerator.NativeFieldInfoPtr_current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170006C1 RID: 1729
			// (get) Token: 0x0600218E RID: 8590 RVA: 0x00091F50 File Offset: 0x00090150
			// (set) Token: 0x0600218F RID: 8591 RVA: 0x0000C73A File Offset: 0x0000A93A
			public unsafe bool moveResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Enumerator.NativeFieldInfoPtr_moveResult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Enumerator.NativeFieldInfoPtr_moveResult)) = value;
				}
			}

			// Token: 0x170006C2 RID: 1730
			// (get) Token: 0x06002190 RID: 8592 RVA: 0x00091F78 File Offset: 0x00090178
			// (set) Token: 0x06002191 RID: 8593 RVA: 0x0000C755 File Offset: 0x0000A955
			public unsafe long version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Enumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Enumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x170006C3 RID: 1731
			// (get) Token: 0x06002192 RID: 8594 RVA: 0x00091FA0 File Offset: 0x000901A0
			// (set) Token: 0x06002193 RID: 8595 RVA: 0x0000C770 File Offset: 0x0000A970
			public unsafe bool disposed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Enumerator.NativeFieldInfoPtr_disposed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Enumerator.NativeFieldInfoPtr_disposed)) = value;
				}
			}

			// Token: 0x040020FC RID: 8444
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x040020FD RID: 8445
			private static readonly IntPtr NativeFieldInfoPtr_currentNode;

			// Token: 0x040020FE RID: 8446
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x040020FF RID: 8447
			private static readonly IntPtr NativeFieldInfoPtr_moveResult;

			// Token: 0x04002100 RID: 8448
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x04002101 RID: 8449
			private static readonly IntPtr NativeFieldInfoPtr_disposed;

			// Token: 0x04002102 RID: 8450
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Deque_1_T_0;

			// Token: 0x04002103 RID: 8451
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002104 RID: 8452
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04002105 RID: 8453
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04002106 RID: 8454
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x04002107 RID: 8455
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000267 RID: 615
		[Serializable]
		public class Node : Object
		{
			// Token: 0x06002194 RID: 8596 RVA: 0x00091FC8 File Offset: 0x000901C8
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<Deque<T>.Node>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, "Node"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Deque<T>.Node>.NativeClassPtr);
				Deque<T>.Node.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>.Node>.NativeClassPtr, "value");
				Deque<T>.Node.NativeFieldInfoPtr_previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>.Node>.NativeClassPtr, "previous");
				Deque<T>.Node.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>.Node>.NativeClassPtr, "next");
				Deque<T>.Node.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.Node>.NativeClassPtr, 100666916);
				Deque<T>.Node.NativeMethodInfoPtr_get_Value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.Node>.NativeClassPtr, 100666917);
				Deque<T>.Node.NativeMethodInfoPtr_get_Previous_Public_get_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.Node>.NativeClassPtr, 100666918);
				Deque<T>.Node.NativeMethodInfoPtr_set_Previous_Public_set_Void_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.Node>.NativeClassPtr, 100666919);
				Deque<T>.Node.NativeMethodInfoPtr_get_Next_Public_get_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.Node>.NativeClassPtr, 100666920);
				Deque<T>.Node.NativeMethodInfoPtr_set_Next_Public_set_Void_Node_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.Node>.NativeClassPtr, 100666921);
			}

			// Token: 0x06002195 RID: 8597 RVA: 0x000920E4 File Offset: 0x000902E4
			[CallerCount(0)]
			public unsafe Node(T value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Deque<T>.Node>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						if (!(t is string))
						{
							ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref value;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.Node.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170006C9 RID: 1737
			// (get) Token: 0x06002196 RID: 8598 RVA: 0x0009217C File Offset: 0x0009037C
			public unsafe T Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.Node.NativeMethodInfoPtr_get_Value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x170006CA RID: 1738
			// (get) Token: 0x06002197 RID: 8599 RVA: 0x000921B8 File Offset: 0x000903B8
			// (set) Token: 0x06002198 RID: 8600 RVA: 0x000921F8 File Offset: 0x000903F8
			public unsafe Deque<T>.Node Previous
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.Node.NativeMethodInfoPtr_get_Previous_Public_get_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Deque<T>.Node>(intPtr3) : null;
				}
				[CallerCount(58)]
				[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.Node.NativeMethodInfoPtr_set_Previous_Public_set_Void_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170006CB RID: 1739
			// (get) Token: 0x06002199 RID: 8601 RVA: 0x0009223C File Offset: 0x0009043C
			// (set) Token: 0x0600219A RID: 8602 RVA: 0x0009227C File Offset: 0x0009047C
			public unsafe Deque<T>.Node Next
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.Node.NativeMethodInfoPtr_get_Next_Public_get_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Deque<T>.Node>(intPtr3) : null;
				}
				[CallerCount(33)]
				[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.Node.NativeMethodInfoPtr_set_Next_Public_set_Void_Node_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600219B RID: 8603 RVA: 0x0000C78B File Offset: 0x0000A98B
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006C6 RID: 1734
			// (get) Token: 0x0600219C RID: 8604 RVA: 0x000922C0 File Offset: 0x000904C0
			// (set) Token: 0x0600219D RID: 8605 RVA: 0x000922E8 File Offset: 0x000904E8
			public unsafe T value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Node.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Node.NativeFieldInfoPtr_value);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170006C7 RID: 1735
			// (get) Token: 0x0600219E RID: 8606 RVA: 0x00092390 File Offset: 0x00090590
			// (set) Token: 0x0600219F RID: 8607 RVA: 0x0000C794 File Offset: 0x0000A994
			public unsafe Deque<T>.Node previous
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Node.NativeFieldInfoPtr_previous);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque<T>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Node.NativeFieldInfoPtr_previous), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006C8 RID: 1736
			// (get) Token: 0x060021A0 RID: 8608 RVA: 0x000923C0 File Offset: 0x000905C0
			// (set) Token: 0x060021A1 RID: 8609 RVA: 0x0000C7B3 File Offset: 0x0000A9B3
			public unsafe Deque<T>.Node next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Node.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque<T>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.Node.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002108 RID: 8456
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04002109 RID: 8457
			private static readonly IntPtr NativeFieldInfoPtr_previous;

			// Token: 0x0400210A RID: 8458
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x0400210B RID: 8459
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

			// Token: 0x0400210C RID: 8460
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_T_0;

			// Token: 0x0400210D RID: 8461
			private static readonly IntPtr NativeMethodInfoPtr_get_Previous_Public_get_Node_T_0;

			// Token: 0x0400210E RID: 8462
			private static readonly IntPtr NativeMethodInfoPtr_set_Previous_Public_set_Void_Node_T_0;

			// Token: 0x0400210F RID: 8463
			private static readonly IntPtr NativeMethodInfoPtr_get_Next_Public_get_Node_T_0;

			// Token: 0x04002110 RID: 8464
			private static readonly IntPtr NativeMethodInfoPtr_set_Next_Public_set_Void_Node_T_0;
		}

		// Token: 0x02000268 RID: 616
		[Serializable]
		public class SynchronizedDeque : Deque<T>
		{
			// Token: 0x060021A2 RID: 8610 RVA: 0x000923F0 File Offset: 0x000905F0
			// Note: this type is marked as 'beforefieldinit'.
			static SynchronizedDeque()
			{
				Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Deque<T>>.NativeClassPtr, "SynchronizedDeque"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr);
				Deque<T>.SynchronizedDeque.NativeFieldInfoPtr_deque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, "deque");
				Deque<T>.SynchronizedDeque.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, "root");
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr__ctor_Public_Void_Deque_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666922);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666923);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666924);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_PushFront_Public_Virtual_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666925);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_PushBack_Public_Virtual_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666926);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_PopFront_Public_Virtual_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666927);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_PopBack_Public_Virtual_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666928);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_PeekFront_Public_Virtual_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666929);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_PeekBack_Public_Virtual_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666930);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666931);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666932);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666933);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666934);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666935);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666936);
				Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr, 100666937);
			}

			// Token: 0x060021A3 RID: 8611 RVA: 0x000925C0 File Offset: 0x000907C0
			[CallerCount(0)]
			public unsafe SynchronizedDeque(Deque<T> deque)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Deque<T>.SynchronizedDeque>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(deque);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.SynchronizedDeque.NativeMethodInfoPtr__ctor_Public_Void_Deque_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021A4 RID: 8612 RVA: 0x0009260C File Offset: 0x0009080C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20168, XrefRangeEnd = 20171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021A5 RID: 8613 RVA: 0x00092648 File Offset: 0x00090848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20171, XrefRangeEnd = 20174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Contains(T item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = item;
						if (!(t is string))
						{
							ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021A6 RID: 8614 RVA: 0x000926EC File Offset: 0x000908EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void PushFront(T item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = item;
						if (!(t is string))
						{
							ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_PushFront_Public_Virtual_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021A7 RID: 8615 RVA: 0x00092784 File Offset: 0x00090984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20174, XrefRangeEnd = 20177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void PushBack(T item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					IntPtr* ptr2 = ptr;
					ref T ptr4;
					if (!typeof(T).IsValueType)
					{
						T t = item;
						if (!(t is string))
						{
							ref T ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
							if ((ref ptr3) != null)
							{
								ptr4 = ref ptr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
								{
									ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
								}
							}
						}
						else
						{
							ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
						}
					}
					else
					{
						ptr4 = ref item;
					}
					*ptr2 = ref ptr4;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_PushBack_Public_Virtual_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060021A8 RID: 8616 RVA: 0x0009281C File Offset: 0x00090A1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20177, XrefRangeEnd = 20180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override T PopFront()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_PopFront_Public_Virtual_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x060021A9 RID: 8617 RVA: 0x00092860 File Offset: 0x00090A60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20180, XrefRangeEnd = 20183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override T PopBack()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_PopBack_Public_Virtual_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x060021AA RID: 8618 RVA: 0x000928A4 File Offset: 0x00090AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20183, XrefRangeEnd = 20186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override T PeekFront()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_PeekFront_Public_Virtual_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x060021AB RID: 8619 RVA: 0x000928E8 File Offset: 0x00090AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20186, XrefRangeEnd = 20189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override T PeekBack()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_PeekBack_Public_Virtual_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x060021AC RID: 8620 RVA: 0x0009292C File Offset: 0x00090B2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20189, XrefRangeEnd = 20192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Il2CppArrayBase<T> ToArray()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppArrayBase_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}

			// Token: 0x060021AD RID: 8621 RVA: 0x00092970 File Offset: 0x00090B70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20192, XrefRangeEnd = 20195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060021AE RID: 8622 RVA: 0x000929BC File Offset: 0x00090BBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20195, XrefRangeEnd = 20198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021AF RID: 8623 RVA: 0x00092A18 File Offset: 0x00090C18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20198, XrefRangeEnd = 20201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerator<T> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x060021B0 RID: 8624 RVA: 0x00092A64 File Offset: 0x00090C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20201, XrefRangeEnd = 20207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x170006CE RID: 1742
			// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00092AA4 File Offset: 0x00090CA4
			public unsafe override int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20207, XrefRangeEnd = 20210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170006CF RID: 1743
			// (get) Token: 0x060021B2 RID: 8626 RVA: 0x00092AEC File Offset: 0x00090CEC
			public unsafe override bool IsSynchronized
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Deque<T>.SynchronizedDeque.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021B3 RID: 8627 RVA: 0x0000C7D2 File Offset: 0x0000A9D2
			public SynchronizedDeque(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006CC RID: 1740
			// (get) Token: 0x060021B4 RID: 8628 RVA: 0x00092B34 File Offset: 0x00090D34
			// (set) Token: 0x060021B5 RID: 8629 RVA: 0x0000C7DB File Offset: 0x0000A9DB
			public unsafe Deque<T> deque
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.SynchronizedDeque.NativeFieldInfoPtr_deque);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Deque<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.SynchronizedDeque.NativeFieldInfoPtr_deque), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CD RID: 1741
			// (get) Token: 0x060021B6 RID: 8630 RVA: 0x00092B64 File Offset: 0x00090D64
			// (set) Token: 0x060021B7 RID: 8631 RVA: 0x0000C7FA File Offset: 0x0000A9FA
			public unsafe Object root
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.SynchronizedDeque.NativeFieldInfoPtr_root);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Deque<T>.SynchronizedDeque.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002111 RID: 8465
			private static readonly IntPtr NativeFieldInfoPtr_deque;

			// Token: 0x04002112 RID: 8466
			private static readonly IntPtr NativeFieldInfoPtr_root;

			// Token: 0x04002113 RID: 8467
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Deque_1_T_0;

			// Token: 0x04002114 RID: 8468
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

			// Token: 0x04002115 RID: 8469
			private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Boolean_T_0;

			// Token: 0x04002116 RID: 8470
			private static readonly IntPtr NativeMethodInfoPtr_PushFront_Public_Virtual_Void_T_0;

			// Token: 0x04002117 RID: 8471
			private static readonly IntPtr NativeMethodInfoPtr_PushBack_Public_Virtual_Void_T_0;

			// Token: 0x04002118 RID: 8472
			private static readonly IntPtr NativeMethodInfoPtr_PopFront_Public_Virtual_T_0;

			// Token: 0x04002119 RID: 8473
			private static readonly IntPtr NativeMethodInfoPtr_PopBack_Public_Virtual_T_0;

			// Token: 0x0400211A RID: 8474
			private static readonly IntPtr NativeMethodInfoPtr_PeekFront_Public_Virtual_T_0;

			// Token: 0x0400211B RID: 8475
			private static readonly IntPtr NativeMethodInfoPtr_PeekBack_Public_Virtual_T_0;

			// Token: 0x0400211C RID: 8476
			private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Virtual_Il2CppArrayBase_1_T_0;

			// Token: 0x0400211D RID: 8477
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

			// Token: 0x0400211E RID: 8478
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Array_Int32_0;

			// Token: 0x0400211F RID: 8479
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_1_T_0;

			// Token: 0x04002120 RID: 8480
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04002121 RID: 8481
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

			// Token: 0x04002122 RID: 8482
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_get_Boolean_0;
		}
	}
}
