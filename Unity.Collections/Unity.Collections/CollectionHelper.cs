using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000008 RID: 8
	public static class CollectionHelper : Object
	{
		// Token: 0x06000030 RID: 48 RVA: 0x0000405C File Offset: 0x0000225C
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionHelper()
		{
			Il2CppClassPointerStore<CollectionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "CollectionHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionHelper>.NativeClassPtr);
			CollectionHelper.NativeMethodInfoPtr_Align_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionHelper>.NativeClassPtr, 100663378);
			CollectionHelper.NativeMethodInfoPtr_Hash_Public_Static_UInt32_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionHelper>.NativeClassPtr, 100663379);
			CollectionHelper.NativeMethodInfoPtr_ShouldDeallocate_Internal_Static_Boolean_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionHelper>.NativeClassPtr, 100663380);
			CollectionHelper.NativeMethodInfoPtr_AssumePositive_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionHelper>.NativeClassPtr, 100663381);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000040DC File Offset: 0x000022DC
		[CallerCount(0)]
		public unsafe static int Align(int size, int alignmentPowerOfTwo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignmentPowerOfTwo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionHelper.NativeMethodInfoPtr_Align_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004128 File Offset: 0x00002328
		[CallerCount(0)]
		public unsafe static uint Hash(void* ptr, int bytes)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionHelper.NativeMethodInfoPtr_Hash_Public_Static_UInt32_ptr_Void_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004174 File Offset: 0x00002374
		[CallerCount(0)]
		public unsafe static bool ShouldDeallocate(AllocatorManager.AllocatorHandle allocator)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocator;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionHelper.NativeMethodInfoPtr_ShouldDeallocate_Internal_Static_Boolean_AllocatorHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000041B4 File Offset: 0x000023B4
		[CallerCount(0)]
		public unsafe static int AssumePositive(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionHelper.NativeMethodInfoPtr_AssumePositive_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000021DD File Offset: 0x000003DD
		public CollectionHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_Align_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_Hash_Public_Static_UInt32_ptr_Void_Int32_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_ShouldDeallocate_Internal_Static_Boolean_AllocatorHandle_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_AssumePositive_Internal_Static_Int32_Int32_0;
	}
}
