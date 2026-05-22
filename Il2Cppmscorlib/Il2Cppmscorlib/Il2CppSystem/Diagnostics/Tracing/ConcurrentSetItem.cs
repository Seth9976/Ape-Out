using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C4 RID: 1220
	public class ConcurrentSetItem<KeyType, ItemType> : Object where ItemType : ConcurrentSetItem<KeyType, ItemType>
	{
		// Token: 0x0600492D RID: 18733 RVA: 0x00152EC8 File Offset: 0x001510C8
		// Note: this type is marked as 'beforefieldinit'.
		static ConcurrentSetItem()
		{
			Il2CppClassPointerStore<ConcurrentSetItem<KeyType, ItemType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ConcurrentSetItem`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<KeyType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ItemType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentSetItem<KeyType, ItemType>>.NativeClassPtr);
			ConcurrentSetItem<KeyType, ItemType>.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentSetItem<KeyType, ItemType>>.NativeClassPtr, 100674246);
			ConcurrentSetItem<KeyType, ItemType>.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_KeyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentSetItem<KeyType, ItemType>>.NativeClassPtr, 100674247);
			ConcurrentSetItem<KeyType, ItemType>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentSetItem<KeyType, ItemType>>.NativeClassPtr, 100674248);
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x00152F84 File Offset: 0x00151184
		[CallerCount(0)]
		public unsafe virtual int Compare(ItemType other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				IntPtr* ptr2 = ptr;
				ref ItemType ptr4;
				if (!typeof(ItemType).IsValueType)
				{
					ItemType itemType = other;
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
					ptr4 = ref other;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConcurrentSetItem<KeyType, ItemType>.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_ItemType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x00153028 File Offset: 0x00151228
		[CallerCount(0)]
		public unsafe virtual int Compare(KeyType key)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConcurrentSetItem<KeyType, ItemType>.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_KeyType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x001530CC File Offset: 0x001512CC
		[CallerCount(0)]
		public unsafe ConcurrentSetItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentSetItem<KeyType, ItemType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentSetItem<KeyType, ItemType>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x0001B5BD File Offset: 0x000197BD
		public ConcurrentSetItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003B43 RID: 15171
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_ItemType_0;

		// Token: 0x04003B44 RID: 15172
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_KeyType_0;

		// Token: 0x04003B45 RID: 15173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
