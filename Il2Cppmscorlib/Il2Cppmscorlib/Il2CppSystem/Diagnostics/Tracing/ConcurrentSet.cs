using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C3 RID: 1219
	public sealed class ConcurrentSet<KeyType, ItemType> : ValueType where ItemType : ConcurrentSetItem<KeyType, ItemType>
	{
		// Token: 0x06004926 RID: 18726 RVA: 0x00152CAC File Offset: 0x00150EAC
		// Note: this type is marked as 'beforefieldinit'.
		static ConcurrentSet()
		{
			Il2CppClassPointerStore<ConcurrentSet<KeyType, ItemType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ConcurrentSet`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<KeyType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ItemType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentSet<KeyType, ItemType>>.NativeClassPtr);
			ConcurrentSet<KeyType, ItemType>.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentSet<KeyType, ItemType>>.NativeClassPtr, "items");
			ConcurrentSet<KeyType, ItemType>.NativeMethodInfoPtr_TryGet_Public_ItemType_KeyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentSet<KeyType, ItemType>>.NativeClassPtr, 100674244);
			ConcurrentSet<KeyType, ItemType>.NativeMethodInfoPtr_GetOrAdd_Public_ItemType_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentSet<KeyType, ItemType>>.NativeClassPtr, 100674245);
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x00152D68 File Offset: 0x00150F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233507, RefRangeEnd = 233508, XrefRangeStart = 233506, XrefRangeEnd = 233507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemType TryGet(KeyType key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref KeyType ptr4;
				if (!typeof(KeyType).IsValueType)
				{
					KeyType keyType = key;
					if (!(keyType is string))
					{
						ref KeyType ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(keyType as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(keyType as string);
					}
				}
				else
				{
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentSet<KeyType, ItemType>.NativeMethodInfoPtr_TryGet_Public_ItemType_KeyType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<ItemType>(intPtr, false, true);
			}
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x00152E04 File Offset: 0x00151004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233519, RefRangeEnd = 233520, XrefRangeStart = 233508, XrefRangeEnd = 233519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemType GetOrAdd(ItemType newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref ItemType ptr4;
				if (!typeof(ItemType).IsValueType)
				{
					ItemType itemType = newItem;
					if (!(itemType is string))
					{
						ref ItemType ptr3 = (ptr4 = IL2CPP.Il2CppObjectBaseToPtr(itemType as Il2CppObjectBase));
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(itemType as string);
					}
				}
				else
				{
					ptr4 = ref newItem;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentSet<KeyType, ItemType>.NativeMethodInfoPtr_GetOrAdd_Public_ItemType_ItemType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<ItemType>(intPtr, false, true);
			}
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x0001B583 File Offset: 0x00019783
		public ConcurrentSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x0001B58C File Offset: 0x0001978C
		public ConcurrentSet()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentSet<KeyType, ItemType>>.NativeClassPtr))
		{
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x0600492B RID: 18731 RVA: 0x00152EA0 File Offset: 0x001510A0
		// (set) Token: 0x0600492C RID: 18732 RVA: 0x0001B59E File Offset: 0x0001979E
		public unsafe Il2CppArrayBase<ItemType> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentSet<KeyType, ItemType>.NativeFieldInfoPtr_items);
				return Il2CppArrayBase<ItemType>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentSet<KeyType, ItemType>.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B40 RID: 15168
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04003B41 RID: 15169
		private static readonly IntPtr NativeMethodInfoPtr_TryGet_Public_ItemType_KeyType_0;

		// Token: 0x04003B42 RID: 15170
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAdd_Public_ItemType_ItemType_0;
	}
}
