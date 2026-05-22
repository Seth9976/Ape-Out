using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Unity.Collections
{
	// Token: 0x0200001F RID: 31
	[StructLayout(2)]
	public struct Memory
	{
		// Token: 0x060000DC RID: 220 RVA: 0x000024B0 File Offset: 0x000006B0
		// Note: this type is marked as 'beforefieldinit'.
		static Memory()
		{
			Il2CppClassPointerStore<Memory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "Memory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Memory>.NativeClassPtr);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000024D5 File Offset: 0x000006D5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Memory>.NativeClassPtr, ref this));
		}

		// Token: 0x0200004C RID: 76
		[StructLayout(2)]
		public struct Unmanaged
		{
			// Token: 0x060002CB RID: 715 RVA: 0x00010BBC File Offset: 0x0000EDBC
			// Note: this type is marked as 'beforefieldinit'.
			static Unmanaged()
			{
				Il2CppClassPointerStore<Memory.Unmanaged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Memory>.NativeClassPtr, "Unmanaged");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Memory.Unmanaged>.NativeClassPtr);
				Memory.Unmanaged.NativeMethodInfoPtr_Allocate_Internal_Static_ptr_Void_Int64_Int32_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory.Unmanaged>.NativeClassPtr, 100663479);
				Memory.Unmanaged.NativeMethodInfoPtr_Free_Internal_Static_Void_ptr_Void_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory.Unmanaged>.NativeClassPtr, 100663480);
				Memory.Unmanaged.NativeMethodInfoPtr_Free_Internal_Static_Void_ptr_T_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory.Unmanaged>.NativeClassPtr, 100663481);
			}

			// Token: 0x060002CC RID: 716 RVA: 0x00010C24 File Offset: 0x0000EE24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440443, XrefRangeEnd = 440444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void* Allocate(long size, int align, AllocatorManager.AllocatorHandle allocator)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory.Unmanaged.NativeMethodInfoPtr_Allocate_Internal_Static_ptr_Void_Int64_Int32_AllocatorHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}

			// Token: 0x060002CD RID: 717 RVA: 0x00010C74 File Offset: 0x0000EE74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440444, XrefRangeEnd = 440445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Free(void* pointer, AllocatorManager.AllocatorHandle allocator)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = pointer;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory.Unmanaged.NativeMethodInfoPtr_Free_Internal_Static_Void_ptr_Void_AllocatorHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002CE RID: 718 RVA: 0x00010CB4 File Offset: 0x0000EEB4
			[CallerCount(0)]
			public unsafe static void Free<T>(T* pointer, AllocatorManager.AllocatorHandle allocator) where T : new()
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = pointer;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory.Unmanaged.MethodInfoStoreGeneric_Free_Internal_Static_Void_ptr_T_AllocatorHandle_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002CF RID: 719 RVA: 0x0000347A File Offset: 0x0000167A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Memory.Unmanaged>.NativeClassPtr, ref this));
			}

			// Token: 0x0400051B RID: 1307
			private static readonly IntPtr NativeMethodInfoPtr_Allocate_Internal_Static_ptr_Void_Int64_Int32_AllocatorHandle_0;

			// Token: 0x0400051C RID: 1308
			private static readonly IntPtr NativeMethodInfoPtr_Free_Internal_Static_Void_ptr_Void_AllocatorHandle_0;

			// Token: 0x0400051D RID: 1309
			private static readonly IntPtr NativeMethodInfoPtr_Free_Internal_Static_Void_ptr_T_AllocatorHandle_0;

			// Token: 0x02000069 RID: 105
			[StructLayout(2)]
			public struct Array
			{
				// Token: 0x06000346 RID: 838 RVA: 0x00012AE0 File Offset: 0x00010CE0
				// Note: this type is marked as 'beforefieldinit'.
				static Array()
				{
					Il2CppClassPointerStore<Memory.Unmanaged.Array>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Memory.Unmanaged>.NativeClassPtr, "Array");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Memory.Unmanaged.Array>.NativeClassPtr);
					Memory.Unmanaged.Array.NativeMethodInfoPtr_IsCustom_Private_Static_Boolean_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory.Unmanaged.Array>.NativeClassPtr, 100663482);
					Memory.Unmanaged.Array.NativeMethodInfoPtr_CustomResize_Private_Static_ptr_Void_ptr_Void_Int64_Int64_AllocatorHandle_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory.Unmanaged.Array>.NativeClassPtr, 100663483);
					Memory.Unmanaged.Array.NativeMethodInfoPtr_Resize_Internal_Static_ptr_Void_ptr_Void_Int64_Int64_AllocatorHandle_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory.Unmanaged.Array>.NativeClassPtr, 100663484);
					Memory.Unmanaged.Array.NativeMethodInfoPtr_Resize_Internal_Static_ptr_T_ptr_T_Int64_Int64_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Memory.Unmanaged.Array>.NativeClassPtr, 100663485);
				}

				// Token: 0x06000347 RID: 839 RVA: 0x00012B5C File Offset: 0x00010D5C
				[CallerCount(0)]
				public unsafe static bool IsCustom(AllocatorManager.AllocatorHandle allocator)
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref allocator;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory.Unmanaged.Array.NativeMethodInfoPtr_IsCustom_Private_Static_Boolean_AllocatorHandle_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06000348 RID: 840 RVA: 0x00012B9C File Offset: 0x00010D9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440417, XrefRangeEnd = 440422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static void* CustomResize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align)
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = oldPointer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldCount;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCount;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory.Unmanaged.Array.NativeMethodInfoPtr_CustomResize_Private_Static_ptr_Void_ptr_Void_Int64_Int64_AllocatorHandle_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x06000349 RID: 841 RVA: 0x00012C14 File Offset: 0x00010E14
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 440432, RefRangeEnd = 440442, XrefRangeStart = 440422, XrefRangeEnd = 440432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static void* Resize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align)
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = oldPointer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldCount;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCount;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory.Unmanaged.Array.NativeMethodInfoPtr_Resize_Internal_Static_ptr_Void_ptr_Void_Int64_Int64_AllocatorHandle_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x0600034A RID: 842 RVA: 0x00012C8C File Offset: 0x00010E8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440442, XrefRangeEnd = 440443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static T* Resize<T>(T* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator) where T : new()
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = oldPointer;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldCount;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCount;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allocator;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Memory.Unmanaged.Array.MethodInfoStoreGeneric_Resize_Internal_Static_ptr_T_ptr_T_Int64_Int64_AllocatorHandle_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}

				// Token: 0x0600034B RID: 843 RVA: 0x00003678 File Offset: 0x00001878
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Memory.Unmanaged.Array>.NativeClassPtr, ref this));
				}

				// Token: 0x04000575 RID: 1397
				private static readonly IntPtr NativeMethodInfoPtr_IsCustom_Private_Static_Boolean_AllocatorHandle_0;

				// Token: 0x04000576 RID: 1398
				private static readonly IntPtr NativeMethodInfoPtr_CustomResize_Private_Static_ptr_Void_ptr_Void_Int64_Int64_AllocatorHandle_Int64_Int32_0;

				// Token: 0x04000577 RID: 1399
				private static readonly IntPtr NativeMethodInfoPtr_Resize_Internal_Static_ptr_Void_ptr_Void_Int64_Int64_AllocatorHandle_Int64_Int32_0;

				// Token: 0x04000578 RID: 1400
				private static readonly IntPtr NativeMethodInfoPtr_Resize_Internal_Static_ptr_T_ptr_T_Int64_Int64_AllocatorHandle_0;

				// Token: 0x0200006B RID: 107
				private sealed class MethodInfoStoreGeneric_Resize_Internal_Static_ptr_T_ptr_T_Int64_Int64_AllocatorHandle_0<T>
				{
					// Token: 0x0400057A RID: 1402
					internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Memory.Unmanaged.Array.NativeMethodInfoPtr_Resize_Internal_Static_ptr_T_ptr_T_Int64_Int64_AllocatorHandle_0, Il2CppClassPointerStore<Memory.Unmanaged.Array>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
				}
			}

			// Token: 0x0200006A RID: 106
			private sealed class MethodInfoStoreGeneric_Free_Internal_Static_Void_ptr_T_AllocatorHandle_0<T>
			{
				// Token: 0x04000579 RID: 1401
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Memory.Unmanaged.NativeMethodInfoPtr_Free_Internal_Static_Void_ptr_T_AllocatorHandle_0, Il2CppClassPointerStore<Memory.Unmanaged>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}
	}
}
