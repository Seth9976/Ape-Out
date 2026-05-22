using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Data
{
	// Token: 0x0200011E RID: 286
	public class ExpandableArray_DataContainer<T> : Object where T : class, new()
	{
		// Token: 0x06001D49 RID: 7497 RVA: 0x0009BCE4 File Offset: 0x00099EE4
		// Note: this type is marked as 'beforefieldinit'.
		static ExpandableArray_DataContainer()
		{
			Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Data", "ExpandableArray_DataContainer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr);
			ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_injector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, "injector");
			ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_AhZgAmlxvKWYRwmeoDmBUNNmMgu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, "AhZgAmlxvKWYRwmeoDmBUNNmMgu");
			ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_XNvtxARFWTNgAvMqsDqlgagZBqP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, "XNvtxARFWTNgAvMqsDqlgagZBqP");
			ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_ZaSEIsgrnCanehusGbSjvfAftit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, "ZaSEIsgrnCanehusGbSjvfAftit");
			ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_JXqUCYbJIxVioMfPOluQFiIufFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, "JXqUCYbJIxVioMfPOluQFiIufFT");
			ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_xJNGTGnfMeARcDsZSPZmZcdUUNxr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, "xJNGTGnfMeARcDsZSPZmZcdUUNxr");
			ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_aamwveJIElUoYDMtaFCfHJMvjzi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, "aamwveJIElUoYDMtaFCfHJMvjzi");
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669744);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669745);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_get_MaxLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669746);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_get_FreeSpace_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669747);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669748);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669749);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_Inject_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669750);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_InjectIfUnique_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669751);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_AddData_Public_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669752);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_AddIfUnique_Public_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669753);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_ContainsData_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669754);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_IndexOfData_Public_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669755);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669756);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669757);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_RemoveLast_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669758);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_Resize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669759);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_SortAscending_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669760);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_SortDescending_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669761);
			ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_zKOHlhHLVgmjJzBtdFsHFrubUjMm_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, 100669762);
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x0009BF58 File Offset: 0x0009A158
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x0009BF94 File Offset: 0x0009A194
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x0009BFD0 File Offset: 0x0009A1D0
		public unsafe int MaxLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_get_MaxLength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x0009C00C File Offset: 0x0009A20C
		public unsafe int FreeSpace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_get_FreeSpace_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x0009C048 File Offset: 0x0009A248
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 280510, RefRangeEnd = 280516, XrefRangeStart = 280508, XrefRangeEnd = 280510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpandableArray_DataContainer(int startingMaxLength, bool clearData = true, int expansionIncrement = 0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingMaxLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expansionIncrement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009FD RID: 2557
		public unsafe T this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 280516, RefRangeEnd = 280517, XrefRangeStart = 280516, XrefRangeEnd = 280516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x0009C0F4 File Offset: 0x0009A2F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280519, RefRangeEnd = 280520, XrefRangeStart = 280517, XrefRangeEnd = 280519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Inject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_Inject_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x0009C130 File Offset: 0x0009A330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280520, XrefRangeEnd = 280522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InjectIfUnique()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_InjectIfUnique_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x0009C16C File Offset: 0x0009A36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280522, XrefRangeEnd = 280525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddData(T item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_AddData_Public_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x0009C204 File Offset: 0x0009A404
		[CallerCount(0)]
		public unsafe int AddIfUnique(T item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_AddIfUnique_Public_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x0009C29C File Offset: 0x0009A49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280525, XrefRangeEnd = 280527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsData(T item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_ContainsData_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x0009C334 File Offset: 0x0009A534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280527, XrefRangeEnd = 280529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfData(T item)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_IndexOfData_Public_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x0009C3CC File Offset: 0x0009A5CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 280533, RefRangeEnd = 280540, XrefRangeStart = 280529, XrefRangeEnd = 280533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x0009C400 File Offset: 0x0009A600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280548, RefRangeEnd = 280549, XrefRangeStart = 280540, XrefRangeEnd = 280548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x0009C440 File Offset: 0x0009A640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280549, XrefRangeEnd = 280551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLast()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_RemoveLast_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x0009C474 File Offset: 0x0009A674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280551, XrefRangeEnd = 280557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_Resize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x0009C4B4 File Offset: 0x0009A6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280557, XrefRangeEnd = 280561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortAscending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_SortAscending_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x0009C4E8 File Offset: 0x0009A6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280561, XrefRangeEnd = 280565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortDescending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_SortDescending_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x0009C51C File Offset: 0x0009A71C
		[CallerCount(0)]
		public unsafe void zKOHlhHLVgmjJzBtdFsHFrubUjMm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpandableArray_DataContainer<T>.NativeMethodInfoPtr_zKOHlhHLVgmjJzBtdFsHFrubUjMm_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x0000C198 File Offset: 0x0000A398
		public ExpandableArray_DataContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x0009C550 File Offset: 0x0009A750
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x0009C578 File Offset: 0x0009A778
		public unsafe T injector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_injector);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_injector);
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

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x0009C620 File Offset: 0x0009A820
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x0000C1A1 File Offset: 0x0000A3A1
		public unsafe Il2CppArrayBase<T> AhZgAmlxvKWYRwmeoDmBUNNmMgu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_AhZgAmlxvKWYRwmeoDmBUNNmMgu);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_AhZgAmlxvKWYRwmeoDmBUNNmMgu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x0009C648 File Offset: 0x0009A848
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x0000C1C0 File Offset: 0x0000A3C0
		public unsafe int XNvtxARFWTNgAvMqsDqlgagZBqP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_XNvtxARFWTNgAvMqsDqlgagZBqP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_XNvtxARFWTNgAvMqsDqlgagZBqP)) = value;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x0009C670 File Offset: 0x0009A870
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x0000C1DB File Offset: 0x0000A3DB
		public unsafe int ZaSEIsgrnCanehusGbSjvfAftit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_ZaSEIsgrnCanehusGbSjvfAftit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_ZaSEIsgrnCanehusGbSjvfAftit)) = value;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x0009C698 File Offset: 0x0009A898
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x0000C1F6 File Offset: 0x0000A3F6
		public unsafe int JXqUCYbJIxVioMfPOluQFiIufFT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_JXqUCYbJIxVioMfPOluQFiIufFT);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_JXqUCYbJIxVioMfPOluQFiIufFT)) = value;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x0009C6C0 File Offset: 0x0009A8C0
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x0000C211 File Offset: 0x0000A411
		public unsafe int xJNGTGnfMeARcDsZSPZmZcdUUNxr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_xJNGTGnfMeARcDsZSPZmZcdUUNxr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_xJNGTGnfMeARcDsZSPZmZcdUUNxr)) = value;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x0009C6E8 File Offset: 0x0009A8E8
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x0000C22C File Offset: 0x0000A42C
		public unsafe bool aamwveJIElUoYDMtaFCfHJMvjzi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_aamwveJIElUoYDMtaFCfHJMvjzi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpandableArray_DataContainer<T>.NativeFieldInfoPtr_aamwveJIElUoYDMtaFCfHJMvjzi)) = value;
			}
		}

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeFieldInfoPtr_injector;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeFieldInfoPtr_AhZgAmlxvKWYRwmeoDmBUNNmMgu;

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeFieldInfoPtr_XNvtxARFWTNgAvMqsDqlgagZBqP;

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeFieldInfoPtr_ZaSEIsgrnCanehusGbSjvfAftit;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeFieldInfoPtr_JXqUCYbJIxVioMfPOluQFiIufFT;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeFieldInfoPtr_xJNGTGnfMeARcDsZSPZmZcdUUNxr;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeFieldInfoPtr_aamwveJIElUoYDMtaFCfHJMvjzi;

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxLength_Public_get_Int32_0;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeMethodInfoPtr_get_FreeSpace_Public_get_Int32_0;

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Int32_0;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeMethodInfoPtr_Inject_Public_Int32_0;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeMethodInfoPtr_InjectIfUnique_Public_Int32_0;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_AddData_Public_Int32_T_0;

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeMethodInfoPtr_AddIfUnique_Public_Int32_T_0;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeMethodInfoPtr_ContainsData_Public_Boolean_T_0;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfData_Public_Int32_T_0;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLast_Public_Void_0;

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Public_Void_Int32_0;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeMethodInfoPtr_SortAscending_Public_Void_0;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeMethodInfoPtr_SortDescending_Public_Void_0;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeMethodInfoPtr_zKOHlhHLVgmjJzBtdFsHFrubUjMm_Private_Void_0;

		// Token: 0x02000335 RID: 821
		public class gfUCPUCljmsTsuEZKInQAUVEKCwx : Il2CppObjectBase
		{
			// Token: 0x06004595 RID: 17813 RVA: 0x0014452C File Offset: 0x0014272C
			// Note: this type is marked as 'beforefieldinit'.
			static gfUCPUCljmsTsuEZKInQAUVEKCwx()
			{
				Il2CppClassPointerStore<ExpandableArray_DataContainer<T>.gfUCPUCljmsTsuEZKInQAUVEKCwx>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>>.NativeClassPtr, "gfUCPUCljmsTsuEZKInQAUVEKCwx"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				ExpandableArray_DataContainer<T>.gfUCPUCljmsTsuEZKInQAUVEKCwx.NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Abstract_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>.gfUCPUCljmsTsuEZKInQAUVEKCwx>.NativeClassPtr, 100669763);
				ExpandableArray_DataContainer<T>.gfUCPUCljmsTsuEZKInQAUVEKCwx.NativeMethodInfoPtr_IrrqjlxJUgjJRmwPgXSuZpiUFbk_Public_Abstract_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>.gfUCPUCljmsTsuEZKInQAUVEKCwx>.NativeClassPtr, 100669764);
				ExpandableArray_DataContainer<T>.gfUCPUCljmsTsuEZKInQAUVEKCwx.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpandableArray_DataContainer<T>.gfUCPUCljmsTsuEZKInQAUVEKCwx>.NativeClassPtr, 100669765);
			}

			// Token: 0x06004596 RID: 17814 RVA: 0x001445C4 File Offset: 0x001427C4
			[CallerCount(0)]
			public unsafe virtual void MRZTryplKgDXZkLfSZwrsdDSOdq(T A_1)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpandableArray_DataContainer<T>.gfUCPUCljmsTsuEZKInQAUVEKCwx.NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Abstract_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004597 RID: 17815 RVA: 0x0014465C File Offset: 0x0014285C
			[CallerCount(0)]
			public unsafe virtual bool IrrqjlxJUgjJRmwPgXSuZpiUFbk(T A_1)
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpandableArray_DataContainer<T>.gfUCPUCljmsTsuEZKInQAUVEKCwx.NativeMethodInfoPtr_IrrqjlxJUgjJRmwPgXSuZpiUFbk_Public_Abstract_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004598 RID: 17816 RVA: 0x00144700 File Offset: 0x00142900
			[CallerCount(0)]
			public unsafe virtual void GMFpQqtyJcjzYToWCrZsZQAhPYh()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpandableArray_DataContainer<T>.gfUCPUCljmsTsuEZKInQAUVEKCwx.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004599 RID: 17817 RVA: 0x00019116 File Offset: 0x00017316
			public gfUCPUCljmsTsuEZKInQAUVEKCwx(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040038E2 RID: 14562
			private static readonly IntPtr NativeMethodInfoPtr_MRZTryplKgDXZkLfSZwrsdDSOdq_Public_Abstract_Virtual_New_Void_T_0;

			// Token: 0x040038E3 RID: 14563
			private static readonly IntPtr NativeMethodInfoPtr_IrrqjlxJUgjJRmwPgXSuZpiUFbk_Public_Abstract_Virtual_New_Boolean_T_0;

			// Token: 0x040038E4 RID: 14564
			private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Abstract_Virtual_New_Void_0;
		}
	}
}
