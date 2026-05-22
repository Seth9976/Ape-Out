using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000025 RID: 37
	public sealed class NativeMultiHashMapIterator<TKey> : ValueType where TKey : new()
	{
		// Token: 0x0600010A RID: 266 RVA: 0x00009EC8 File Offset: 0x000080C8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMultiHashMapIterator()
		{
			Il2CppClassPointerStore<NativeMultiHashMapIterator<TKey>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "NativeMultiHashMapIterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMultiHashMapIterator<TKey>>.NativeClassPtr);
			NativeMultiHashMapIterator<TKey>.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMultiHashMapIterator<TKey>>.NativeClassPtr, "key");
			NativeMultiHashMapIterator<TKey>.NativeFieldInfoPtr_NextEntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMultiHashMapIterator<TKey>>.NativeClassPtr, "NextEntryIndex");
			NativeMultiHashMapIterator<TKey>.NativeFieldInfoPtr_EntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMultiHashMapIterator<TKey>>.NativeClassPtr, "EntryIndex");
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000259C File Offset: 0x0000079C
		public NativeMultiHashMapIterator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000025A5 File Offset: 0x000007A5
		public NativeMultiHashMapIterator()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeMultiHashMapIterator<TKey>>.NativeClassPtr))
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00009F70 File Offset: 0x00008170
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00009F98 File Offset: 0x00008198
		public unsafe TKey key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMultiHashMapIterator<TKey>.NativeFieldInfoPtr_key);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMultiHashMapIterator<TKey>.NativeFieldInfoPtr_key);
				Type typeFromHandle = typeof(TKey);
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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000A040 File Offset: 0x00008240
		// (set) Token: 0x06000110 RID: 272 RVA: 0x000025B7 File Offset: 0x000007B7
		public unsafe int NextEntryIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMultiHashMapIterator<TKey>.NativeFieldInfoPtr_NextEntryIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMultiHashMapIterator<TKey>.NativeFieldInfoPtr_NextEntryIndex)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000A068 File Offset: 0x00008268
		// (set) Token: 0x06000112 RID: 274 RVA: 0x000025D2 File Offset: 0x000007D2
		public unsafe int EntryIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMultiHashMapIterator<TKey>.NativeFieldInfoPtr_EntryIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMultiHashMapIterator<TKey>.NativeFieldInfoPtr_EntryIndex)) = value;
			}
		}

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeFieldInfoPtr_NextEntryIndex;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeFieldInfoPtr_EntryIndex;
	}
}
