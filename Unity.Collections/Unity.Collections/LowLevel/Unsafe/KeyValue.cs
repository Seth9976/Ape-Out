using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200002D RID: 45
	public sealed class KeyValue<TKey, TValue> : ValueType where TKey : new() where TValue : new()
	{
		// Token: 0x060001BC RID: 444 RVA: 0x0000CE30 File Offset: 0x0000B030
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValue()
		{
			Il2CppClassPointerStore<KeyValue<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections.LowLevel.Unsafe", "KeyValue`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValue<TKey, TValue>>.NativeClassPtr);
			KeyValue<TKey, TValue>.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValue<TKey, TValue>>.NativeClassPtr, "m_Buffer");
			KeyValue<TKey, TValue>.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValue<TKey, TValue>>.NativeClassPtr, "m_Index");
			KeyValue<TKey, TValue>.NativeFieldInfoPtr_m_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValue<TKey, TValue>>.NativeClassPtr, "m_Next");
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000291D File Offset: 0x00000B1D
		public KeyValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002926 File Offset: 0x00000B26
		public KeyValue()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyValue<TKey, TValue>>.NativeClassPtr))
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000CEEC File Offset: 0x0000B0EC
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002938 File Offset: 0x00000B38
		public unsafe UnsafeHashMapData* m_Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValue<TKey, TValue>.NativeFieldInfoPtr_m_Buffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValue<TKey, TValue>.NativeFieldInfoPtr_m_Buffer)) = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000CF10 File Offset: 0x0000B110
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002953 File Offset: 0x00000B53
		public unsafe int m_Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValue<TKey, TValue>.NativeFieldInfoPtr_m_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValue<TKey, TValue>.NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000CF38 File Offset: 0x0000B138
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000296E File Offset: 0x00000B6E
		public unsafe int m_Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValue<TKey, TValue>.NativeFieldInfoPtr_m_Next);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValue<TKey, TValue>.NativeFieldInfoPtr_m_Next)) = value;
			}
		}

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr_m_Next;
	}
}
