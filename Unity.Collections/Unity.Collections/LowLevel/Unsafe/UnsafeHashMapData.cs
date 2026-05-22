using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200002B RID: 43
	[StructLayout(2)]
	public struct UnsafeHashMapData
	{
		// Token: 0x060001AD RID: 429 RVA: 0x0000C71C File Offset: 0x0000A91C
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeHashMapData()
		{
			Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections.LowLevel.Unsafe", "UnsafeHashMapData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr);
			UnsafeHashMapData.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, "values");
			UnsafeHashMapData.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, "keys");
			UnsafeHashMapData.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, "next");
			UnsafeHashMapData.NativeFieldInfoPtr_buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, "buckets");
			UnsafeHashMapData.NativeFieldInfoPtr_keyCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, "keyCapacity");
			UnsafeHashMapData.NativeFieldInfoPtr_bucketCapacityMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, "bucketCapacityMask");
			UnsafeHashMapData.NativeFieldInfoPtr_allocatedIndexLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, "allocatedIndexLength");
			UnsafeHashMapData.NativeFieldInfoPtr_firstFreeTLS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, "firstFreeTLS");
			UnsafeHashMapData.NativeMethodInfoPtr_GetBucketSize_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, 100663631);
			UnsafeHashMapData.NativeMethodInfoPtr_GrowCapacity_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, 100663632);
			UnsafeHashMapData.NativeMethodInfoPtr_AllocateHashMap_Internal_Static_Void_Int32_Int32_AllocatorHandle_byref_ptr_UnsafeHashMapData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, 100663633);
			UnsafeHashMapData.NativeMethodInfoPtr_ReallocateHashMap_Internal_Static_Void_ptr_UnsafeHashMapData_Int32_Int32_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, 100663634);
			UnsafeHashMapData.NativeMethodInfoPtr_DeallocateHashMap_Internal_Static_Void_ptr_UnsafeHashMapData_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, 100663635);
			UnsafeHashMapData.NativeMethodInfoPtr_CalculateDataSize_Internal_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, 100663636);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000C864 File Offset: 0x0000AA64
		[CallerCount(0)]
		public unsafe static int GetBucketSize(int capacity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMapData.NativeMethodInfoPtr_GetBucketSize_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000C8A4 File Offset: 0x0000AAA4
		[CallerCount(0)]
		public unsafe static int GrowCapacity(int capacity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMapData.NativeMethodInfoPtr_GrowCapacity_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441301, XrefRangeEnd = 441305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AllocateHashMap<TKey, TValue>(int length, int bucketLength, AllocatorManager.AllocatorHandle label, out UnsafeHashMapData* outBuf) where TKey : new() where TValue : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bucketLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref label;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMapData.MethodInfoStoreGeneric_AllocateHashMap_Internal_Static_Void_Int32_Int32_AllocatorHandle_byref_ptr_UnsafeHashMapData_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outBuf = ((intPtr4 == 0) ? null : new UnsafeHashMapData*(intPtr4));
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000C954 File Offset: 0x0000AB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441305, XrefRangeEnd = 441315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReallocateHashMap<TKey, TValue>(UnsafeHashMapData* data, int newCapacity, int newBucketCapacity, AllocatorManager.AllocatorHandle label) where TKey : new() where TValue : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCapacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newBucketCapacity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref label;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMapData.MethodInfoStoreGeneric_ReallocateHashMap_Internal_Static_Void_ptr_UnsafeHashMapData_Int32_Int32_AllocatorHandle_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441315, XrefRangeEnd = 441319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeallocateHashMap(UnsafeHashMapData* data, AllocatorManager.AllocatorHandle allocator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMapData.NativeMethodInfoPtr_DeallocateHashMap_Internal_Static_Void_ptr_UnsafeHashMapData_AllocatorHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441319, XrefRangeEnd = 441320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CalculateDataSize<TKey, TValue>(int length, int bucketLength, out int keyOffset, out int nextOffset, out int bucketOffset) where TKey : new() where TValue : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bucketLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &keyOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nextOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bucketOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeHashMapData.MethodInfoStoreGeneric_CalculateDataSize_Internal_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_0<TKey, TValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000028F0 File Offset: 0x00000AF0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, ref this));
		}

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr_keys;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr_buckets;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeFieldInfoPtr_keyCapacity;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr_bucketCapacityMask;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr_allocatedIndexLength;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_firstFreeTLS;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_GetBucketSize_Internal_Static_Int32_Int32_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_GrowCapacity_Internal_Static_Int32_Int32_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_AllocateHashMap_Internal_Static_Void_Int32_Int32_AllocatorHandle_byref_ptr_UnsafeHashMapData_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_ReallocateHashMap_Internal_Static_Void_ptr_UnsafeHashMapData_Int32_Int32_AllocatorHandle_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_DeallocateHashMap_Internal_Static_Void_ptr_UnsafeHashMapData_AllocatorHandle_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_CalculateDataSize_Internal_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x0400045A RID: 1114
		[FieldOffset(0)]
		public IntPtr values;

		// Token: 0x0400045B RID: 1115
		[FieldOffset(8)]
		public IntPtr keys;

		// Token: 0x0400045C RID: 1116
		[FieldOffset(16)]
		public IntPtr next;

		// Token: 0x0400045D RID: 1117
		[FieldOffset(24)]
		public IntPtr buckets;

		// Token: 0x0400045E RID: 1118
		[FieldOffset(32)]
		public int keyCapacity;

		// Token: 0x0400045F RID: 1119
		[FieldOffset(36)]
		public int bucketCapacityMask;

		// Token: 0x04000460 RID: 1120
		[FieldOffset(40)]
		public int allocatedIndexLength;

		// Token: 0x04000461 RID: 1121
		[FieldOffset(64)]
		public UnsafeHashMapData._firstFreeTLS_e__FixedBuffer firstFreeTLS;

		// Token: 0x0200005A RID: 90
		[ObfuscatedName("Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData+<firstFreeTLS>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _firstFreeTLS_e__FixedBuffer
		{
			// Token: 0x06000315 RID: 789 RVA: 0x00003522 File Offset: 0x00001722
			// Note: this type is marked as 'beforefieldinit'.
			static _firstFreeTLS_e__FixedBuffer()
			{
				Il2CppClassPointerStore<UnsafeHashMapData._firstFreeTLS_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr, "<firstFreeTLS>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeHashMapData._firstFreeTLS_e__FixedBuffer>.NativeClassPtr);
				UnsafeHashMapData._firstFreeTLS_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeHashMapData._firstFreeTLS_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06000316 RID: 790 RVA: 0x00003556 File Offset: 0x00001756
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnsafeHashMapData._firstFreeTLS_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04000556 RID: 1366
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04000557 RID: 1367
			[FieldOffset(0)]
			public int FixedElementField;
		}

		// Token: 0x0200005B RID: 91
		private sealed class MethodInfoStoreGeneric_AllocateHashMap_Internal_Static_Void_Int32_Int32_AllocatorHandle_byref_ptr_UnsafeHashMapData_0<TKey, TValue>
		{
			// Token: 0x04000558 RID: 1368
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeHashMapData.NativeMethodInfoPtr_AllocateHashMap_Internal_Static_Void_Int32_Int32_AllocatorHandle_byref_ptr_UnsafeHashMapData_0, Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200005C RID: 92
		private sealed class MethodInfoStoreGeneric_ReallocateHashMap_Internal_Static_Void_ptr_UnsafeHashMapData_Int32_Int32_AllocatorHandle_0<TKey, TValue>
		{
			// Token: 0x04000559 RID: 1369
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeHashMapData.NativeMethodInfoPtr_ReallocateHashMap_Internal_Static_Void_ptr_UnsafeHashMapData_Int32_Int32_AllocatorHandle_0, Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200005D RID: 93
		private sealed class MethodInfoStoreGeneric_CalculateDataSize_Internal_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_0<TKey, TValue>
		{
			// Token: 0x0400055A RID: 1370
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UnsafeHashMapData.NativeMethodInfoPtr_CalculateDataSize_Internal_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_byref_Int32_0, Il2CppClassPointerStore<UnsafeHashMapData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}
	}
}
