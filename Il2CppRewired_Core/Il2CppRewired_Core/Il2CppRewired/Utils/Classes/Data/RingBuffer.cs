using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x020001B9 RID: 441
	[Serializable]
	public sealed class RingBuffer<T> : Object
	{
		// Token: 0x06002D9C RID: 11676 RVA: 0x000E27D0 File Offset: 0x000E09D0
		// Note: this type is marked as 'beforefieldinit'.
		static RingBuffer()
		{
			Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "RingBuffer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr);
			RingBuffer<T>.NativeFieldInfoPtr_xEbcWnJCCQYGeMDQksstIIGEoZK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "xEbcWnJCCQYGeMDQksstIIGEoZK");
			RingBuffer<T>.NativeFieldInfoPtr_qBWhkDkyhhMvevSGcjJIDmXZcRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "qBWhkDkyhhMvevSGcjJIDmXZcRT");
			RingBuffer<T>.NativeFieldInfoPtr_owrRwcszELYbkqCntBZmmGYXsYt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "owrRwcszELYbkqCntBZmmGYXsYt");
			RingBuffer<T>.NativeFieldInfoPtr_UTzzcTeBGSAgIasjQukbtZfRMfMj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "UTzzcTeBGSAgIasjQukbtZfRMfMj");
			RingBuffer<T>.NativeFieldInfoPtr_BpUQZGuJErUHxYEClmgxzKolRCu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "BpUQZGuJErUHxYEClmgxzKolRCu");
			RingBuffer<T>.NativeFieldInfoPtr_nPUNmOuVhRzcSNqYWKokSdvEbbY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "nPUNmOuVhRzcSNqYWKokSdvEbbY");
			RingBuffer<T>.NativeFieldInfoPtr_HjjnxSNoowqRBXlgFxQnyOTSKdg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "HjjnxSNoowqRBXlgFxQnyOTSKdg");
			RingBuffer<T>.NativeFieldInfoPtr_qWSpxlxDZnYNNekcEdNgQyQDaMi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "qWSpxlxDZnYNNekcEdNgQyQDaMi");
			RingBuffer<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675102);
			RingBuffer<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675103);
			RingBuffer<T>.NativeMethodInfoPtr_get_OverrunCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675104);
			RingBuffer<T>.NativeMethodInfoPtr_get_EqualityComparer_Public_get_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675105);
			RingBuffer<T>.NativeMethodInfoPtr_set_EqualityComparer_Public_set_Void_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675106);
			RingBuffer<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675107);
			RingBuffer<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675108);
			RingBuffer<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675109);
			RingBuffer<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675110);
			RingBuffer<T>.NativeMethodInfoPtr_EnqueueIfUnique_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675111);
			RingBuffer<T>.NativeMethodInfoPtr_Dequeue_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675112);
			RingBuffer<T>.NativeMethodInfoPtr_Peek_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675113);
			RingBuffer<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675114);
			RingBuffer<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675115);
			RingBuffer<T>.NativeMethodInfoPtr_IndexOf_Public_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675116);
			RingBuffer<T>.NativeMethodInfoPtr_IndexOf_Public_Int32_T_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675117);
			RingBuffer<T>.NativeMethodInfoPtr_Remove_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675118);
			RingBuffer<T>.NativeMethodInfoPtr_Remove_Public_Boolean_T_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675119);
			RingBuffer<T>.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675120);
			RingBuffer<T>.NativeMethodInfoPtr_RemoveAll_Public_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675121);
			RingBuffer<T>.NativeMethodInfoPtr_RemoveAll_Public_Int32_T_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675122);
			RingBuffer<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675123);
			RingBuffer<T>.NativeMethodInfoPtr_FtRxQxEvDxQbWzXmNUjpTZQUrvL_Private_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675124);
			RingBuffer<T>.NativeMethodInfoPtr_FtRxQxEvDxQbWzXmNUjpTZQUrvL_Private_Int32_T_IEqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675125);
			RingBuffer<T>.NativeMethodInfoPtr_nDvkSWtRIEhVJExXSKlLSSoLQSU_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675126);
			RingBuffer<T>.NativeMethodInfoPtr_hLpUtIqLzHhjIQrbEGrSeWXBwQp_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675127);
			RingBuffer<T>.NativeMethodInfoPtr_QzQgdgrUOBIRieGQUbXkiPFXiAHs_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675128);
			RingBuffer<T>.NativeMethodInfoPtr_NroLOwPIEbItjUAvMJvYkQCRNOn_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675129);
			RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675130);
			RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675131);
			RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Contains_Private_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675132);
			RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675133);
			RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675134);
			RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675135);
			RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675136);
			RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675137);
			RingBuffer<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, 100675138);
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06002D9D RID: 11677 RVA: 0x000E2BC0 File Offset: 0x000E0DC0
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002D9E RID: 11678 RVA: 0x000E2BFC File Offset: 0x000E0DFC
		public unsafe int Capacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06002D9F RID: 11679 RVA: 0x000E2C38 File Offset: 0x000E0E38
		public unsafe int OverrunCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_get_OverrunCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x000E2C74 File Offset: 0x000E0E74
		// (set) Token: 0x06002DA1 RID: 11681 RVA: 0x000E2CB4 File Offset: 0x000E0EB4
		public unsafe IEqualityComparer<T> EqualityComparer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14016, RefRangeEnd = 14017, XrefRangeStart = 14016, XrefRangeEnd = 14017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_get_EqualityComparer_Public_get_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_set_EqualityComparer_Public_set_Void_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000E8F RID: 3727
		public unsafe T this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331117, XrefRangeEnd = 331124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x000E2DDC File Offset: 0x000E0FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331124, XrefRangeEnd = 331132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RingBuffer(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x000E2E24 File Offset: 0x000E1024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331132, XrefRangeEnd = 331134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(T item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x000E2EB4 File Offset: 0x000E10B4
		[CallerCount(0)]
		public unsafe bool EnqueueIfUnique(T item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_EnqueueIfUnique_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x000E2F4C File Offset: 0x000E114C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331134, XrefRangeEnd = 331135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_Dequeue_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x000E2F88 File Offset: 0x000E1188
		[CallerCount(0)]
		public unsafe T Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_Peek_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x000E2FC4 File Offset: 0x000E11C4
		[CallerCount(0)]
		public unsafe bool Contains(T item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x000E305C File Offset: 0x000E125C
		[CallerCount(0)]
		public unsafe bool Contains(T item, IEqualityComparer<T> comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
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
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_Contains_Public_Boolean_T_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x000E3108 File Offset: 0x000E1308
		[CallerCount(0)]
		public unsafe int IndexOf(T item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_IndexOf_Public_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x000E31A0 File Offset: 0x000E13A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331135, XrefRangeEnd = 331136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(T item, IEqualityComparer<T> comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
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
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_IndexOf_Public_Int32_T_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x000E324C File Offset: 0x000E144C
		[CallerCount(0)]
		public unsafe bool Remove(T item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_Remove_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x000E32E4 File Offset: 0x000E14E4
		[CallerCount(0)]
		public unsafe bool Remove(T item, IEqualityComparer<T> comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
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
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_Remove_Public_Boolean_T_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x000E3390 File Offset: 0x000E1590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331136, XrefRangeEnd = 331137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x000E33D0 File Offset: 0x000E15D0
		[CallerCount(0)]
		public unsafe int RemoveAll(T item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_RemoveAll_Public_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x000E3468 File Offset: 0x000E1668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331137, XrefRangeEnd = 331139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RemoveAll(T item, IEqualityComparer<T> comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
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
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_RemoveAll_Public_Int32_T_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x000E3514 File Offset: 0x000E1714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331139, XrefRangeEnd = 331142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x000E3548 File Offset: 0x000E1748
		[CallerCount(0)]
		public unsafe int FtRxQxEvDxQbWzXmNUjpTZQUrvL(T A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = A_1;
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
					ptr4 = ref A_1;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_FtRxQxEvDxQbWzXmNUjpTZQUrvL_Private_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x000E35E0 File Offset: 0x000E17E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331142, XrefRangeEnd = 331147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FtRxQxEvDxQbWzXmNUjpTZQUrvL(T A_1, IEqualityComparer<T> A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = A_1;
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
					ptr4 = ref A_1;
				}
				*ptr2 = ref ptr4;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_FtRxQxEvDxQbWzXmNUjpTZQUrvL_Private_Int32_T_IEqualityComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x000E368C File Offset: 0x000E188C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331147, XrefRangeEnd = 331152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void nDvkSWtRIEhVJExXSKlLSSoLQSU(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_nDvkSWtRIEhVJExXSKlLSSoLQSU_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x000E36CC File Offset: 0x000E18CC
		[CallerCount(0)]
		public unsafe bool hLpUtIqLzHhjIQrbEGrSeWXBwQp(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_hLpUtIqLzHhjIQrbEGrSeWXBwQp_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x000E3718 File Offset: 0x000E1918
		[CallerCount(0)]
		public unsafe int QzQgdgrUOBIRieGQUbXkiPFXiAHs(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_QzQgdgrUOBIRieGQUbXkiPFXiAHs_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x000E3764 File Offset: 0x000E1964
		[CallerCount(0)]
		public unsafe int NroLOwPIEbItjUAvMJvYkQCRNOn(int A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_NroLOwPIEbItjUAvMJvYkQCRNOn_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x000E37B0 File Offset: 0x000E19B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_Generic_ICollection_T__Add(T item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x000E3840 File Offset: 0x000E1A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331152, XrefRangeEnd = 331153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_Generic_ICollection_T__Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x000E3874 File Offset: 0x000E1A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331153, XrefRangeEnd = 331154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_Collections_Generic_ICollection_T__Contains(T item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Contains_Private_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x000E390C File Offset: 0x000E1B0C
		[CallerCount(0)]
		public unsafe void System_Collections_Generic_ICollection_T__CopyTo(Il2CppArrayBase<T> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06002DBD RID: 11709 RVA: 0x000E395C File Offset: 0x000E1B5C
		public unsafe int System.Collections.Generic.ICollection<T>.Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331154, XrefRangeEnd = 331155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06002DBE RID: 11710 RVA: 0x000E3998 File Offset: 0x000E1B98
		public unsafe bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x000E39D4 File Offset: 0x000E1BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331155, XrefRangeEnd = 331156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_Collections_Generic_ICollection_T__Remove(T item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x000E3A6C File Offset: 0x000E1C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331156, XrefRangeEnd = 331158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x000E3AAC File Offset: 0x000E1CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00010E4E File Offset: 0x0000F04E
		public RingBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x000E3AEC File Offset: 0x000E1CEC
		// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x00010E57 File Offset: 0x0000F057
		public unsafe Il2CppArrayBase<T> xEbcWnJCCQYGeMDQksstIIGEoZK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_xEbcWnJCCQYGeMDQksstIIGEoZK);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_xEbcWnJCCQYGeMDQksstIIGEoZK), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x000E3B14 File Offset: 0x000E1D14
		// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x00010E76 File Offset: 0x0000F076
		public unsafe int qBWhkDkyhhMvevSGcjJIDmXZcRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_qBWhkDkyhhMvevSGcjJIDmXZcRT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_qBWhkDkyhhMvevSGcjJIDmXZcRT)) = value;
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06002DC7 RID: 11719 RVA: 0x000E3B3C File Offset: 0x000E1D3C
		// (set) Token: 0x06002DC8 RID: 11720 RVA: 0x00010E91 File Offset: 0x0000F091
		public unsafe int owrRwcszELYbkqCntBZmmGYXsYt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_owrRwcszELYbkqCntBZmmGYXsYt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_owrRwcszELYbkqCntBZmmGYXsYt)) = value;
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x000E3B64 File Offset: 0x000E1D64
		// (set) Token: 0x06002DCA RID: 11722 RVA: 0x00010EAC File Offset: 0x0000F0AC
		public unsafe int UTzzcTeBGSAgIasjQukbtZfRMfMj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_UTzzcTeBGSAgIasjQukbtZfRMfMj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_UTzzcTeBGSAgIasjQukbtZfRMfMj)) = value;
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x000E3B8C File Offset: 0x000E1D8C
		// (set) Token: 0x06002DCC RID: 11724 RVA: 0x00010EC7 File Offset: 0x0000F0C7
		public unsafe int BpUQZGuJErUHxYEClmgxzKolRCu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_BpUQZGuJErUHxYEClmgxzKolRCu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_BpUQZGuJErUHxYEClmgxzKolRCu)) = value;
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06002DCD RID: 11725 RVA: 0x000E3BB4 File Offset: 0x000E1DB4
		// (set) Token: 0x06002DCE RID: 11726 RVA: 0x00010EE2 File Offset: 0x0000F0E2
		public unsafe int nPUNmOuVhRzcSNqYWKokSdvEbbY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_nPUNmOuVhRzcSNqYWKokSdvEbbY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_nPUNmOuVhRzcSNqYWKokSdvEbbY)) = value;
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06002DCF RID: 11727 RVA: 0x000E3BDC File Offset: 0x000E1DDC
		// (set) Token: 0x06002DD0 RID: 11728 RVA: 0x00010EFD File Offset: 0x0000F0FD
		public unsafe int HjjnxSNoowqRBXlgFxQnyOTSKdg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_HjjnxSNoowqRBXlgFxQnyOTSKdg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_HjjnxSNoowqRBXlgFxQnyOTSKdg)) = value;
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x000E3C04 File Offset: 0x000E1E04
		// (set) Token: 0x06002DD2 RID: 11730 RVA: 0x00010F18 File Offset: 0x0000F118
		public unsafe IEqualityComparer<T> qWSpxlxDZnYNNekcEdNgQyQDaMi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_qWSpxlxDZnYNNekcEdNgQyQDaMi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.NativeFieldInfoPtr_qWSpxlxDZnYNNekcEdNgQyQDaMi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026A4 RID: 9892
		private static readonly IntPtr NativeFieldInfoPtr_xEbcWnJCCQYGeMDQksstIIGEoZK;

		// Token: 0x040026A5 RID: 9893
		private static readonly IntPtr NativeFieldInfoPtr_qBWhkDkyhhMvevSGcjJIDmXZcRT;

		// Token: 0x040026A6 RID: 9894
		private static readonly IntPtr NativeFieldInfoPtr_owrRwcszELYbkqCntBZmmGYXsYt;

		// Token: 0x040026A7 RID: 9895
		private static readonly IntPtr NativeFieldInfoPtr_UTzzcTeBGSAgIasjQukbtZfRMfMj;

		// Token: 0x040026A8 RID: 9896
		private static readonly IntPtr NativeFieldInfoPtr_BpUQZGuJErUHxYEClmgxzKolRCu;

		// Token: 0x040026A9 RID: 9897
		private static readonly IntPtr NativeFieldInfoPtr_nPUNmOuVhRzcSNqYWKokSdvEbbY;

		// Token: 0x040026AA RID: 9898
		private static readonly IntPtr NativeFieldInfoPtr_HjjnxSNoowqRBXlgFxQnyOTSKdg;

		// Token: 0x040026AB RID: 9899
		private static readonly IntPtr NativeFieldInfoPtr_qWSpxlxDZnYNNekcEdNgQyQDaMi;

		// Token: 0x040026AC RID: 9900
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040026AD RID: 9901
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x040026AE RID: 9902
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrunCount_Public_get_Int32_0;

		// Token: 0x040026AF RID: 9903
		private static readonly IntPtr NativeMethodInfoPtr_get_EqualityComparer_Public_get_IEqualityComparer_1_T_0;

		// Token: 0x040026B0 RID: 9904
		private static readonly IntPtr NativeMethodInfoPtr_set_EqualityComparer_Public_set_Void_IEqualityComparer_1_T_0;

		// Token: 0x040026B1 RID: 9905
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

		// Token: 0x040026B2 RID: 9906
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_T_0;

		// Token: 0x040026B3 RID: 9907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040026B4 RID: 9908
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_T_0;

		// Token: 0x040026B5 RID: 9909
		private static readonly IntPtr NativeMethodInfoPtr_EnqueueIfUnique_Public_Boolean_T_0;

		// Token: 0x040026B6 RID: 9910
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_T_0;

		// Token: 0x040026B7 RID: 9911
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_T_0;

		// Token: 0x040026B8 RID: 9912
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_T_0;

		// Token: 0x040026B9 RID: 9913
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_T_IEqualityComparer_1_T_0;

		// Token: 0x040026BA RID: 9914
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_T_0;

		// Token: 0x040026BB RID: 9915
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_T_IEqualityComparer_1_T_0;

		// Token: 0x040026BC RID: 9916
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_T_0;

		// Token: 0x040026BD RID: 9917
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_T_IEqualityComparer_1_T_0;

		// Token: 0x040026BE RID: 9918
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

		// Token: 0x040026BF RID: 9919
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Int32_T_0;

		// Token: 0x040026C0 RID: 9920
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Int32_T_IEqualityComparer_1_T_0;

		// Token: 0x040026C1 RID: 9921
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040026C2 RID: 9922
		private static readonly IntPtr NativeMethodInfoPtr_FtRxQxEvDxQbWzXmNUjpTZQUrvL_Private_Int32_T_0;

		// Token: 0x040026C3 RID: 9923
		private static readonly IntPtr NativeMethodInfoPtr_FtRxQxEvDxQbWzXmNUjpTZQUrvL_Private_Int32_T_IEqualityComparer_1_T_0;

		// Token: 0x040026C4 RID: 9924
		private static readonly IntPtr NativeMethodInfoPtr_nDvkSWtRIEhVJExXSKlLSSoLQSU_Private_Void_Int32_0;

		// Token: 0x040026C5 RID: 9925
		private static readonly IntPtr NativeMethodInfoPtr_hLpUtIqLzHhjIQrbEGrSeWXBwQp_Private_Boolean_Int32_0;

		// Token: 0x040026C6 RID: 9926
		private static readonly IntPtr NativeMethodInfoPtr_QzQgdgrUOBIRieGQUbXkiPFXiAHs_Private_Int32_Int32_0;

		// Token: 0x040026C7 RID: 9927
		private static readonly IntPtr NativeMethodInfoPtr_NroLOwPIEbItjUAvMJvYkQCRNOn_Private_Int32_Int32_0;

		// Token: 0x040026C8 RID: 9928
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0;

		// Token: 0x040026C9 RID: 9929
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x040026CA RID: 9930
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Contains_Private_Virtual_Final_New_Boolean_T_0;

		// Token: 0x040026CB RID: 9931
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040026CC RID: 9932
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_Count_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x040026CD RID: 9933
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040026CE RID: 9934
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0;

		// Token: 0x040026CF RID: 9935
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x040026D0 RID: 9936
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x020003D7 RID: 983
		[Serializable]
		public sealed class SrkadblzHazEhQKaHLCZChhEsjH : ValueType
		{
			// Token: 0x0600501C RID: 20508 RVA: 0x0016C678 File Offset: 0x0016A878
			// Note: this type is marked as 'beforefieldinit'.
			static SrkadblzHazEhQKaHLCZChhEsjH()
			{
				Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RingBuffer<T>>.NativeClassPtr, "SrkadblzHazEhQKaHLCZChhEsjH"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr);
				RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr, "buffer");
				RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr, "index");
				RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr, "version");
				RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr, "current");
				RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr__ctor_Internal_Void_RingBuffer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr, 100675139);
				RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr, 100675140);
				RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr, 100675141);
				RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr_TTbBVkJSpytDiJYhcPJMWwrZRHH_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr, 100675142);
				RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr, 100675143);
				RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr, 100675144);
				RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr, 100675145);
			}

			// Token: 0x0600501D RID: 20509 RVA: 0x0016C7BC File Offset: 0x0016A9BC
			[CallerCount(0)]
			public unsafe SrkadblzHazEhQKaHLCZChhEsjH(RingBuffer<T> buffer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr__ctor_Internal_Void_RingBuffer_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600501E RID: 20510 RVA: 0x0016C80C File Offset: 0x0016AA0C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600501F RID: 20511 RVA: 0x0016C844 File Offset: 0x0016AA44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331114, XrefRangeEnd = 331116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005020 RID: 20512 RVA: 0x0016C888 File Offset: 0x0016AA88
			[CallerCount(0)]
			public unsafe bool TTbBVkJSpytDiJYhcPJMWwrZRHH()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr_TTbBVkJSpytDiJYhcPJMWwrZRHH_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170018DE RID: 6366
			// (get) Token: 0x06005021 RID: 20513 RVA: 0x0016C8CC File Offset: 0x0016AACC
			public unsafe T Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x170018DF RID: 6367
			// (get) Token: 0x06005022 RID: 20514 RVA: 0x0016C90C File Offset: 0x0016AB0C
			public unsafe Object EDfTBMmIlQtjWtkIjwQoFCOMpSp
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331116, XrefRangeEnd = 331117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005023 RID: 20515 RVA: 0x0016C950 File Offset: 0x0016AB50
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005024 RID: 20516 RVA: 0x0001D21A File Offset: 0x0001B41A
			public SrkadblzHazEhQKaHLCZChhEsjH(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005025 RID: 20517 RVA: 0x0001D223 File Offset: 0x0001B423
			public SrkadblzHazEhQKaHLCZChhEsjH()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH>.NativeClassPtr))
			{
			}

			// Token: 0x170018DA RID: 6362
			// (get) Token: 0x06005026 RID: 20518 RVA: 0x0016C988 File Offset: 0x0016AB88
			// (set) Token: 0x06005027 RID: 20519 RVA: 0x0001D235 File Offset: 0x0001B435
			public unsafe RingBuffer<T> buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeFieldInfoPtr_buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RingBuffer<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018DB RID: 6363
			// (get) Token: 0x06005028 RID: 20520 RVA: 0x0016C9B8 File Offset: 0x0016ABB8
			// (set) Token: 0x06005029 RID: 20521 RVA: 0x0001D254 File Offset: 0x0001B454
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170018DC RID: 6364
			// (get) Token: 0x0600502A RID: 20522 RVA: 0x0016C9E0 File Offset: 0x0016ABE0
			// (set) Token: 0x0600502B RID: 20523 RVA: 0x0001D26F File Offset: 0x0001B46F
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x170018DD RID: 6365
			// (get) Token: 0x0600502C RID: 20524 RVA: 0x0016CA08 File Offset: 0x0016AC08
			// (set) Token: 0x0600502D RID: 20525 RVA: 0x0016CA30 File Offset: 0x0016AC30
			public unsafe T current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeFieldInfoPtr_current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RingBuffer<T>.SrkadblzHazEhQKaHLCZChhEsjH.NativeFieldInfoPtr_current);
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

			// Token: 0x040042C1 RID: 17089
			private static readonly IntPtr NativeFieldInfoPtr_buffer;

			// Token: 0x040042C2 RID: 17090
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040042C3 RID: 17091
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x040042C4 RID: 17092
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x040042C5 RID: 17093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_RingBuffer_1_T_0;

			// Token: 0x040042C6 RID: 17094
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040042C7 RID: 17095
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040042C8 RID: 17096
			private static readonly IntPtr NativeMethodInfoPtr_TTbBVkJSpytDiJYhcPJMWwrZRHH_Private_Boolean_0;

			// Token: 0x040042C9 RID: 17097
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x040042CA RID: 17098
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040042CB RID: 17099
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
