using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Burst;

namespace Unity.Collections
{
	// Token: 0x02000004 RID: 4
	public static class AllocatorManager : Object
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00003704 File Offset: 0x00001904
		// Note: this type is marked as 'beforefieldinit'.
		static AllocatorManager()
		{
			Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Collections.dll", "Unity.Collections", "AllocatorManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr);
			AllocatorManager.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "Invalid");
			AllocatorManager.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "None");
			AllocatorManager.NativeFieldInfoPtr_Temp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "Temp");
			AllocatorManager.NativeFieldInfoPtr_TempJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "TempJob");
			AllocatorManager.NativeFieldInfoPtr_Persistent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "Persistent");
			AllocatorManager.NativeFieldInfoPtr_AudioKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "AudioKernel");
			AllocatorManager.NativeMethodInfoPtr_AllocateBlock_Internal_Static_Block_byref_T_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663299);
			AllocatorManager.NativeMethodInfoPtr_Allocate_Internal_Static_ptr_Void_byref_T_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663300);
			AllocatorManager.NativeMethodInfoPtr_Allocate_Internal_Static_ptr_U_byref_T_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663301);
			AllocatorManager.NativeMethodInfoPtr_FreeBlock_Internal_Static_Void_byref_T_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663302);
			AllocatorManager.NativeMethodInfoPtr_Free_Internal_Static_Void_byref_T_ptr_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663303);
			AllocatorManager.NativeMethodInfoPtr_Free_Internal_Static_Void_byref_T_ptr_U_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663304);
			AllocatorManager.NativeMethodInfoPtr_Free_Public_Static_Void_AllocatorHandle_ptr_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663305);
			AllocatorManager.NativeMethodInfoPtr_CheckDelegate_Private_Static_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663306);
			AllocatorManager.NativeMethodInfoPtr_UseDelegate_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663307);
			AllocatorManager.NativeMethodInfoPtr_allocate_block_Private_Static_Int32_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663308);
			AllocatorManager.NativeMethodInfoPtr_forward_mono_allocate_block_Private_Static_Void_byref_Block_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663309);
			AllocatorManager.NativeMethodInfoPtr_LegacyOf_Internal_Static_Allocator_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663310);
			AllocatorManager.NativeMethodInfoPtr_TryLegacy_Private_Static_Int32_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663311);
			AllocatorManager.NativeMethodInfoPtr_Try_Public_Static_Int32_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663312);
			AllocatorManager.NativeMethodInfoPtr_Unregister_Public_Static_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, 100663313);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000038D8 File Offset: 0x00001AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440065, XrefRangeEnd = 440071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AllocatorManager.Block AllocateBlock<T>(this T t, int sizeOf, int alignOf, int items) where T : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(t);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOf;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignOf;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref items;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.MethodInfoStoreGeneric_AllocateBlock_Internal_Static_Block_byref_T_Int32_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			t = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000395C File Offset: 0x00001B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440071, XrefRangeEnd = 440074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* Allocate<T>(this T t, int sizeOf, int alignOf, int items) where T : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(t);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOf;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignOf;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref items;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.MethodInfoStoreGeneric_Allocate_Internal_Static_ptr_Void_byref_T_Int32_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			t = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return intPtr2;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000039D8 File Offset: 0x00001BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440074, XrefRangeEnd = 440077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static U* Allocate<T, U>(this T t, U u, int items) where T : new() where U : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(t);
				ptr2 = &intPtr;
			}
			IntPtr* ptr3 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			ref U ptr5;
			if (!typeof(U).IsValueType)
			{
				U u2 = u;
				if (!(u2 is string))
				{
					ref U ptr4 = (ptr5 = IL2CPP.Il2CppObjectBaseToPtr(u2 as Il2CppObjectBase));
					if ((ref ptr4) != null)
					{
						ptr5 = ref ptr4;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr4)))
						{
							ptr5 = IL2CPP.il2cpp_object_unbox(ref ptr4);
						}
					}
				}
				else
				{
					ptr5 = IL2CPP.ManagedStringToIl2Cpp(u2 as string);
				}
			}
			else
			{
				ptr5 = ref u;
			}
			*ptr3 = ref ptr5;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref items;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.MethodInfoStoreGeneric_Allocate_Internal_Static_ptr_U_byref_T_U_Int32_0<T, U>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			t = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return intPtr2;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003A94 File Offset: 0x00001C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440077, XrefRangeEnd = 440081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FreeBlock<T>(this T t, ref AllocatorManager.Block block) where T : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(t);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.MethodInfoStoreGeneric_FreeBlock_Internal_Static_Void_byref_T_byref_Block_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			t = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003AF0 File Offset: 0x00001CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440081, XrefRangeEnd = 440085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Free<T>(this T t, void* pointer, int sizeOf, int alignOf, int items) where T : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(t);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pointer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeOf;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignOf;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref items;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.MethodInfoStoreGeneric_Free_Internal_Static_Void_byref_T_ptr_Void_Int32_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			t = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003B74 File Offset: 0x00001D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440085, XrefRangeEnd = 440088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Free<T, U>(this T t, U* pointer, int items) where T : new() where U : new()
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(t);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pointer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref items;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.MethodInfoStoreGeneric_Free_Internal_Static_Void_byref_T_ptr_U_Int32_0<T, U>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			t = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003BDC File Offset: 0x00001DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440088, XrefRangeEnd = 440091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Free<T>(AllocatorManager.AllocatorHandle handle, T* pointer, int items = 1) where T : new()
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pointer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref items;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.MethodInfoStoreGeneric_Free_Public_Static_Void_AllocatorHandle_ptr_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003C2C File Offset: 0x00001E2C
		[CallerCount(0)]
		public unsafe static void CheckDelegate(ref bool useDelegate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &useDelegate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.NativeMethodInfoPtr_CheckDelegate_Private_Static_Void_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003C60 File Offset: 0x00001E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440091, XrefRangeEnd = 440094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UseDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.NativeMethodInfoPtr_UseDelegate_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003C90 File Offset: 0x00001E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440094, XrefRangeEnd = 440101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int allocate_block(ref AllocatorManager.Block block)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &block;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.NativeMethodInfoPtr_allocate_block_Private_Static_Int32_byref_Block_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003CD0 File Offset: 0x00001ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440101, XrefRangeEnd = 440107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void forward_mono_allocate_block(ref AllocatorManager.Block block, ref int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &block;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.NativeMethodInfoPtr_forward_mono_allocate_block_Private_Static_Void_byref_Block_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003D10 File Offset: 0x00001F10
		[CallerCount(0)]
		public unsafe static Allocator LegacyOf(AllocatorManager.AllocatorHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.NativeMethodInfoPtr_LegacyOf_Internal_Static_Allocator_AllocatorHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003D50 File Offset: 0x00001F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440119, RefRangeEnd = 440120, XrefRangeStart = 440107, XrefRangeEnd = 440119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TryLegacy(ref AllocatorManager.Block block)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &block;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.NativeMethodInfoPtr_TryLegacy_Private_Static_Int32_byref_Block_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003D90 File Offset: 0x00001F90
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 440156, RefRangeEnd = 440164, XrefRangeStart = 440120, XrefRangeEnd = 440156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Try(ref AllocatorManager.Block block)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &block;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.NativeMethodInfoPtr_Try_Public_Static_Int32_byref_Block_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003DD0 File Offset: 0x00001FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440164, XrefRangeEnd = 440188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Unregister<T>(this T t) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(t);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.MethodInfoStoreGeneric_Unregister_Public_Static_Void_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				t = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020D4 File Offset: 0x000002D4
		public AllocatorManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00003E20 File Offset: 0x00002020
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000020DD File Offset: 0x000002DD
		public unsafe static AllocatorManager.AllocatorHandle Invalid
		{
			get
			{
				AllocatorManager.AllocatorHandle allocatorHandle;
				IL2CPP.il2cpp_field_static_get_value(AllocatorManager.NativeFieldInfoPtr_Invalid, (void*)(&allocatorHandle));
				return allocatorHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AllocatorManager.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003E3C File Offset: 0x0000203C
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000020EB File Offset: 0x000002EB
		public unsafe static AllocatorManager.AllocatorHandle None
		{
			get
			{
				AllocatorManager.AllocatorHandle allocatorHandle;
				IL2CPP.il2cpp_field_static_get_value(AllocatorManager.NativeFieldInfoPtr_None, (void*)(&allocatorHandle));
				return allocatorHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AllocatorManager.NativeFieldInfoPtr_None, (void*)(&value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003E58 File Offset: 0x00002058
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020F9 File Offset: 0x000002F9
		public unsafe static AllocatorManager.AllocatorHandle Temp
		{
			get
			{
				AllocatorManager.AllocatorHandle allocatorHandle;
				IL2CPP.il2cpp_field_static_get_value(AllocatorManager.NativeFieldInfoPtr_Temp, (void*)(&allocatorHandle));
				return allocatorHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AllocatorManager.NativeFieldInfoPtr_Temp, (void*)(&value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003E74 File Offset: 0x00002074
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002107 File Offset: 0x00000307
		public unsafe static AllocatorManager.AllocatorHandle TempJob
		{
			get
			{
				AllocatorManager.AllocatorHandle allocatorHandle;
				IL2CPP.il2cpp_field_static_get_value(AllocatorManager.NativeFieldInfoPtr_TempJob, (void*)(&allocatorHandle));
				return allocatorHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AllocatorManager.NativeFieldInfoPtr_TempJob, (void*)(&value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003E90 File Offset: 0x00002090
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002115 File Offset: 0x00000315
		public unsafe static AllocatorManager.AllocatorHandle Persistent
		{
			get
			{
				AllocatorManager.AllocatorHandle allocatorHandle;
				IL2CPP.il2cpp_field_static_get_value(AllocatorManager.NativeFieldInfoPtr_Persistent, (void*)(&allocatorHandle));
				return allocatorHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AllocatorManager.NativeFieldInfoPtr_Persistent, (void*)(&value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003EAC File Offset: 0x000020AC
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002123 File Offset: 0x00000323
		public unsafe static AllocatorManager.AllocatorHandle AudioKernel
		{
			get
			{
				AllocatorManager.AllocatorHandle allocatorHandle;
				IL2CPP.il2cpp_field_static_get_value(AllocatorManager.NativeFieldInfoPtr_AudioKernel, (void*)(&allocatorHandle));
				return allocatorHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AllocatorManager.NativeFieldInfoPtr_AudioKernel, (void*)(&value));
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_Temp;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_TempJob;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_Persistent;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_AudioKernel;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_AllocateBlock_Internal_Static_Block_byref_T_Int32_Int32_Int32_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Internal_Static_ptr_Void_byref_T_Int32_Int32_Int32_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_Allocate_Internal_Static_ptr_U_byref_T_U_Int32_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_FreeBlock_Internal_Static_Void_byref_T_byref_Block_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_Free_Internal_Static_Void_byref_T_ptr_Void_Int32_Int32_Int32_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_Free_Internal_Static_Void_byref_T_ptr_U_Int32_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_Free_Public_Static_Void_AllocatorHandle_ptr_T_Int32_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_CheckDelegate_Private_Static_Void_byref_Boolean_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_UseDelegate_Private_Static_Boolean_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_allocate_block_Private_Static_Int32_byref_Block_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_forward_mono_allocate_block_Private_Static_Void_byref_Block_byref_Int32_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_LegacyOf_Internal_Static_Allocator_AllocatorHandle_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_TryLegacy_Private_Static_Int32_byref_Block_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_Try_Public_Static_Int32_byref_Block_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Unregister_Public_Static_Void_byref_T_0;

		// Token: 0x02000034 RID: 52
		public sealed class TryFunction : MulticastDelegate
		{
			// Token: 0x060001FE RID: 510 RVA: 0x0000DE28 File Offset: 0x0000C028
			// Note: this type is marked as 'beforefieldinit'.
			static TryFunction()
			{
				Il2CppClassPointerStore<AllocatorManager.TryFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "TryFunction");
				AllocatorManager.TryFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.TryFunction>.NativeClassPtr, 100663315);
				AllocatorManager.TryFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.TryFunction>.NativeClassPtr, 100663316);
				AllocatorManager.TryFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Block_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.TryFunction>.NativeClassPtr, 100663317);
				AllocatorManager.TryFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_byref_Block_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.TryFunction>.NativeClassPtr, 100663318);
			}

			// Token: 0x060001FF RID: 511 RVA: 0x0000DE9C File Offset: 0x0000C09C
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TryFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllocatorManager.TryFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.TryFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000200 RID: 512 RVA: 0x0000DEF8 File Offset: 0x0000C0F8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 439745, RefRangeEnd = 439748, XrefRangeStart = 439745, XrefRangeEnd = 439745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Invoke(IntPtr allocatorState, ref AllocatorManager.Block block)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref allocatorState;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.TryFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_byref_Block_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000201 RID: 513 RVA: 0x0000DF50 File Offset: 0x0000C150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439748, XrefRangeEnd = 439755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IntPtr allocatorState, ref AllocatorManager.Block block, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref allocatorState;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.TryFunction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Block_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000202 RID: 514 RVA: 0x0000DFD0 File Offset: 0x0000C1D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439755, XrefRangeEnd = 439756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(ref AllocatorManager.Block block, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &block;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.TryFunction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_byref_Block_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000203 RID: 515 RVA: 0x00002B20 File Offset: 0x00000D20
			public TryFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400048C RID: 1164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400048D RID: 1165
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_byref_Block_0;

			// Token: 0x0400048E RID: 1166
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Block_AsyncCallback_Object_0;

			// Token: 0x0400048F RID: 1167
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_byref_Block_IAsyncResult_0;
		}

		// Token: 0x02000035 RID: 53
		[StructLayout(2)]
		public struct AllocatorHandle
		{
			// Token: 0x06000204 RID: 516 RVA: 0x0000E02C File Offset: 0x0000C22C
			// Note: this type is marked as 'beforefieldinit'.
			static AllocatorHandle()
			{
				Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "AllocatorHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr);
				AllocatorManager.AllocatorHandle.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr, "Index");
				AllocatorManager.AllocatorHandle.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr, "Version");
				AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_get_TableEntry_Internal_get_byref_TableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr, 100663319);
				AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_get_IsInstalled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr, 100663320);
				AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_Rewind_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr, 100663321);
				AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_Install_Internal_Void_TableEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr, 100663322);
				AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_AllocatorHandle_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr, 100663323);
				AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_get_Value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr, 100663324);
				AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_Try_Public_Virtual_Final_New_Int32_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr, 100663325);
				AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr, 100663326);
				AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_get_ToAllocator_Public_Virtual_Final_New_get_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr, 100663327);
				AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr, 100663328);
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000205 RID: 517 RVA: 0x0000E148 File Offset: 0x0000C348
			public unsafe ref AllocatorManager.TableEntry TableEntry
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 439766, RefRangeEnd = 439771, XrefRangeStart = 439756, XrefRangeEnd = 439766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_get_TableEntry_Internal_get_byref_TableEntry_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000206 RID: 518 RVA: 0x0000E170 File Offset: 0x0000C370
			public unsafe bool IsInstalled
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 439779, RefRangeEnd = 439784, XrefRangeStart = 439771, XrefRangeEnd = 439779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_get_IsInstalled_Internal_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000207 RID: 519 RVA: 0x0000E1A0 File Offset: 0x0000C3A0
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Rewind()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_Rewind_Internal_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000208 RID: 520 RVA: 0x0000E1C8 File Offset: 0x0000C3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439784, XrefRangeEnd = 439785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Install(AllocatorManager.TableEntry tableEntry)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref tableEntry;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_Install_Internal_Void_TableEntry_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000209 RID: 521 RVA: 0x0000E1FC File Offset: 0x0000C3FC
			[CallerCount(0)]
			public unsafe static implicit operator AllocatorManager.AllocatorHandle(Allocator a)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_AllocatorHandle_Allocator_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x0600020A RID: 522 RVA: 0x0000E23C File Offset: 0x0000C43C
			public unsafe int Value
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_get_Value_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600020B RID: 523 RVA: 0x0000E26C File Offset: 0x0000C46C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439785, XrefRangeEnd = 439789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Try(ref AllocatorManager.Block block)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &block;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_Try_Public_Virtual_Final_New_Int32_byref_Block_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x0600020C RID: 524 RVA: 0x0000E2AC File Offset: 0x0000C4AC
			public unsafe AllocatorManager.AllocatorHandle Handle
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_AllocatorHandle_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x0600020D RID: 525 RVA: 0x0000E2DC File Offset: 0x0000C4DC
			public unsafe Allocator ToAllocator
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_get_ToAllocator_Public_Virtual_Final_New_get_Allocator_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600020E RID: 526 RVA: 0x0000E30C File Offset: 0x0000C50C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439789, XrefRangeEnd = 439817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.AllocatorHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600020F RID: 527 RVA: 0x00002B29 File Offset: 0x00000D29
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.AllocatorHandle>.NativeClassPtr, ref this));
			}

			// Token: 0x04000490 RID: 1168
			private static readonly IntPtr NativeFieldInfoPtr_Index;

			// Token: 0x04000491 RID: 1169
			private static readonly IntPtr NativeFieldInfoPtr_Version;

			// Token: 0x04000492 RID: 1170
			private static readonly IntPtr NativeMethodInfoPtr_get_TableEntry_Internal_get_byref_TableEntry_0;

			// Token: 0x04000493 RID: 1171
			private static readonly IntPtr NativeMethodInfoPtr_get_IsInstalled_Internal_get_Boolean_0;

			// Token: 0x04000494 RID: 1172
			private static readonly IntPtr NativeMethodInfoPtr_Rewind_Internal_Void_0;

			// Token: 0x04000495 RID: 1173
			private static readonly IntPtr NativeMethodInfoPtr_Install_Internal_Void_TableEntry_0;

			// Token: 0x04000496 RID: 1174
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AllocatorHandle_Allocator_0;

			// Token: 0x04000497 RID: 1175
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int32_0;

			// Token: 0x04000498 RID: 1176
			private static readonly IntPtr NativeMethodInfoPtr_Try_Public_Virtual_Final_New_Int32_byref_Block_0;

			// Token: 0x04000499 RID: 1177
			private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_AllocatorHandle_0;

			// Token: 0x0400049A RID: 1178
			private static readonly IntPtr NativeMethodInfoPtr_get_ToAllocator_Public_Virtual_Final_New_get_Allocator_0;

			// Token: 0x0400049B RID: 1179
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x0400049C RID: 1180
			[FieldOffset(0)]
			public ushort Index;

			// Token: 0x0400049D RID: 1181
			[FieldOffset(2)]
			public ushort Version;
		}

		// Token: 0x02000036 RID: 54
		[StructLayout(2)]
		public struct Range
		{
			// Token: 0x06000210 RID: 528 RVA: 0x0000E334 File Offset: 0x0000C534
			// Note: this type is marked as 'beforefieldinit'.
			static Range()
			{
				Il2CppClassPointerStore<AllocatorManager.Range>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "Range");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.Range>.NativeClassPtr);
				AllocatorManager.Range.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Range>.NativeClassPtr, "Pointer");
				AllocatorManager.Range.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Range>.NativeClassPtr, "Items");
				AllocatorManager.Range.NativeFieldInfoPtr_Allocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Range>.NativeClassPtr, "Allocator");
				AllocatorManager.Range.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.Range>.NativeClassPtr, 100663329);
			}

			// Token: 0x06000211 RID: 529 RVA: 0x0000E3B0 File Offset: 0x0000C5B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439817, XrefRangeEnd = 439821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.Range.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000212 RID: 530 RVA: 0x00002B3B File Offset: 0x00000D3B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Range>.NativeClassPtr, ref this));
			}

			// Token: 0x0400049E RID: 1182
			private static readonly IntPtr NativeFieldInfoPtr_Pointer;

			// Token: 0x0400049F RID: 1183
			private static readonly IntPtr NativeFieldInfoPtr_Items;

			// Token: 0x040004A0 RID: 1184
			private static readonly IntPtr NativeFieldInfoPtr_Allocator;

			// Token: 0x040004A1 RID: 1185
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040004A2 RID: 1186
			[FieldOffset(0)]
			public IntPtr Pointer;

			// Token: 0x040004A3 RID: 1187
			[FieldOffset(8)]
			public int Items;

			// Token: 0x040004A4 RID: 1188
			[FieldOffset(12)]
			public AllocatorManager.AllocatorHandle Allocator;
		}

		// Token: 0x02000037 RID: 55
		[StructLayout(2)]
		public struct Block
		{
			// Token: 0x06000213 RID: 531 RVA: 0x0000E3D8 File Offset: 0x0000C5D8
			// Note: this type is marked as 'beforefieldinit'.
			static Block()
			{
				Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "Block");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr);
				AllocatorManager.Block.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, "Range");
				AllocatorManager.Block.NativeFieldInfoPtr_BytesPerItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, "BytesPerItem");
				AllocatorManager.Block.NativeFieldInfoPtr_AllocatedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, "AllocatedItems");
				AllocatorManager.Block.NativeFieldInfoPtr_Log2Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, "Log2Alignment");
				AllocatorManager.Block.NativeFieldInfoPtr_Padding0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, "Padding0");
				AllocatorManager.Block.NativeFieldInfoPtr_Padding1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, "Padding1");
				AllocatorManager.Block.NativeFieldInfoPtr_Padding2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, "Padding2");
				AllocatorManager.Block.NativeMethodInfoPtr_get_Bytes_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, 100663330);
				AllocatorManager.Block.NativeMethodInfoPtr_get_AllocatedBytes_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, 100663331);
				AllocatorManager.Block.NativeMethodInfoPtr_get_Alignment_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, 100663332);
				AllocatorManager.Block.NativeMethodInfoPtr_set_Alignment_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, 100663333);
				AllocatorManager.Block.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, 100663334);
				AllocatorManager.Block.NativeMethodInfoPtr_TryFree_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, 100663335);
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000214 RID: 532 RVA: 0x0000E508 File Offset: 0x0000C708
			public unsafe long Bytes
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.Block.NativeMethodInfoPtr_get_Bytes_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000215 RID: 533 RVA: 0x0000E538 File Offset: 0x0000C738
			public unsafe long AllocatedBytes
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.Block.NativeMethodInfoPtr_get_AllocatedBytes_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000216 RID: 534 RVA: 0x0000E568 File Offset: 0x0000C768
			// (set) Token: 0x06000217 RID: 535 RVA: 0x0000E598 File Offset: 0x0000C798
			public unsafe int Alignment
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.Block.NativeMethodInfoPtr_get_Alignment_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.Block.NativeMethodInfoPtr_set_Alignment_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000218 RID: 536 RVA: 0x0000E5CC File Offset: 0x0000C7CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439821, XrefRangeEnd = 439825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.Block.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000219 RID: 537 RVA: 0x0000E5F4 File Offset: 0x0000C7F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int TryFree()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.Block.NativeMethodInfoPtr_TryFree_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600021A RID: 538 RVA: 0x00002B4D File Offset: 0x00000D4D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Block>.NativeClassPtr, ref this));
			}

			// Token: 0x040004A5 RID: 1189
			private static readonly IntPtr NativeFieldInfoPtr_Range;

			// Token: 0x040004A6 RID: 1190
			private static readonly IntPtr NativeFieldInfoPtr_BytesPerItem;

			// Token: 0x040004A7 RID: 1191
			private static readonly IntPtr NativeFieldInfoPtr_AllocatedItems;

			// Token: 0x040004A8 RID: 1192
			private static readonly IntPtr NativeFieldInfoPtr_Log2Alignment;

			// Token: 0x040004A9 RID: 1193
			private static readonly IntPtr NativeFieldInfoPtr_Padding0;

			// Token: 0x040004AA RID: 1194
			private static readonly IntPtr NativeFieldInfoPtr_Padding1;

			// Token: 0x040004AB RID: 1195
			private static readonly IntPtr NativeFieldInfoPtr_Padding2;

			// Token: 0x040004AC RID: 1196
			private static readonly IntPtr NativeMethodInfoPtr_get_Bytes_Public_get_Int64_0;

			// Token: 0x040004AD RID: 1197
			private static readonly IntPtr NativeMethodInfoPtr_get_AllocatedBytes_Public_get_Int64_0;

			// Token: 0x040004AE RID: 1198
			private static readonly IntPtr NativeMethodInfoPtr_get_Alignment_Public_get_Int32_0;

			// Token: 0x040004AF RID: 1199
			private static readonly IntPtr NativeMethodInfoPtr_set_Alignment_Public_set_Void_Int32_0;

			// Token: 0x040004B0 RID: 1200
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040004B1 RID: 1201
			private static readonly IntPtr NativeMethodInfoPtr_TryFree_Public_Int32_0;

			// Token: 0x040004B2 RID: 1202
			[FieldOffset(0)]
			public AllocatorManager.Range Range;

			// Token: 0x040004B3 RID: 1203
			[FieldOffset(16)]
			public int BytesPerItem;

			// Token: 0x040004B4 RID: 1204
			[FieldOffset(20)]
			public int AllocatedItems;

			// Token: 0x040004B5 RID: 1205
			[FieldOffset(24)]
			public byte Log2Alignment;

			// Token: 0x040004B6 RID: 1206
			[FieldOffset(25)]
			public byte Padding0;

			// Token: 0x040004B7 RID: 1207
			[FieldOffset(26)]
			public ushort Padding1;

			// Token: 0x040004B8 RID: 1208
			[FieldOffset(28)]
			public uint Padding2;
		}

		// Token: 0x02000038 RID: 56
		public class IAllocator : Il2CppObjectBase
		{
			// Token: 0x0600021B RID: 539 RVA: 0x00002B5F File Offset: 0x00000D5F
			// Note: this type is marked as 'beforefieldinit'.
			static IAllocator()
			{
				Il2CppClassPointerStore<AllocatorManager.IAllocator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "IAllocator");
				AllocatorManager.IAllocator.NativeMethodInfoPtr_Try_Public_Abstract_Virtual_New_Int32_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.IAllocator>.NativeClassPtr, 100663336);
				AllocatorManager.IAllocator.NativeMethodInfoPtr_get_Handle_Public_Abstract_Virtual_New_get_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.IAllocator>.NativeClassPtr, 100663337);
			}

			// Token: 0x0600021C RID: 540 RVA: 0x0000E624 File Offset: 0x0000C824
			[CallerCount(0)]
			public unsafe virtual int Try(ref AllocatorManager.Block block)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &block;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllocatorManager.IAllocator.NativeMethodInfoPtr_Try_Public_Abstract_Virtual_New_Int32_byref_Block_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x0600021D RID: 541 RVA: 0x0000E678 File Offset: 0x0000C878
			public unsafe virtual AllocatorManager.AllocatorHandle Handle
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllocatorManager.IAllocator.NativeMethodInfoPtr_get_Handle_Public_Abstract_Virtual_New_get_AllocatorHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600021E RID: 542 RVA: 0x00002B9D File Offset: 0x00000D9D
			public IAllocator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040004B9 RID: 1209
			private static readonly IntPtr NativeMethodInfoPtr_Try_Public_Abstract_Virtual_New_Int32_byref_Block_0;

			// Token: 0x040004BA RID: 1210
			private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_Abstract_Virtual_New_get_AllocatorHandle_0;
		}

		// Token: 0x02000039 RID: 57
		[StructLayout(2)]
		public struct StackAllocator
		{
			// Token: 0x0600021F RID: 543 RVA: 0x0000E6C0 File Offset: 0x0000C8C0
			// Note: this type is marked as 'beforefieldinit'.
			static StackAllocator()
			{
				Il2CppClassPointerStore<AllocatorManager.StackAllocator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "StackAllocator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.StackAllocator>.NativeClassPtr);
				AllocatorManager.StackAllocator.NativeFieldInfoPtr_m_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.StackAllocator>.NativeClassPtr, "m_handle");
				AllocatorManager.StackAllocator.NativeFieldInfoPtr_m_storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.StackAllocator>.NativeClassPtr, "m_storage");
				AllocatorManager.StackAllocator.NativeFieldInfoPtr_m_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.StackAllocator>.NativeClassPtr, "m_top");
				AllocatorManager.StackAllocator.NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator>.NativeClassPtr, 100663338);
				AllocatorManager.StackAllocator.NativeMethodInfoPtr_Try_Public_Virtual_Final_New_Int32_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator>.NativeClassPtr, 100663339);
				AllocatorManager.StackAllocator.NativeMethodInfoPtr_Try_Public_Static_Int32_IntPtr_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator>.NativeClassPtr, 100663340);
				AllocatorManager.StackAllocator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator>.NativeClassPtr, 100663341);
				AllocatorManager.StackAllocator.NativeMethodInfoPtr_Method_Public_Static_Int32_IntPtr_byref_Block_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator>.NativeClassPtr, 100663342);
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x06000220 RID: 544 RVA: 0x0000E78C File Offset: 0x0000C98C
			public unsafe AllocatorManager.AllocatorHandle Handle
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_AllocatorHandle_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000221 RID: 545 RVA: 0x0000E7BC File Offset: 0x0000C9BC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 439890, RefRangeEnd = 439893, XrefRangeStart = 439889, XrefRangeEnd = 439890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Try(ref AllocatorManager.Block block)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &block;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.NativeMethodInfoPtr_Try_Public_Virtual_Final_New_Int32_byref_Block_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000222 RID: 546 RVA: 0x0000E7FC File Offset: 0x0000C9FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439893, XrefRangeEnd = 439905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int Try(IntPtr allocatorState, ref AllocatorManager.Block block)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref allocatorState;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.NativeMethodInfoPtr_Try_Public_Static_Int32_IntPtr_byref_Block_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000223 RID: 547 RVA: 0x0000E848 File Offset: 0x0000CA48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439905, XrefRangeEnd = 439933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000224 RID: 548 RVA: 0x0000E870 File Offset: 0x0000CA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439933, XrefRangeEnd = 439934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int Method_Public_Static_Int32_IntPtr_byref_Block_PDM_0(IntPtr allocatorState, ref AllocatorManager.Block block)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref allocatorState;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.NativeMethodInfoPtr_Method_Public_Static_Int32_IntPtr_byref_Block_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000225 RID: 549 RVA: 0x00002BA6 File Offset: 0x00000DA6
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.StackAllocator>.NativeClassPtr, ref this));
			}

			// Token: 0x040004BB RID: 1211
			private static readonly IntPtr NativeFieldInfoPtr_m_handle;

			// Token: 0x040004BC RID: 1212
			private static readonly IntPtr NativeFieldInfoPtr_m_storage;

			// Token: 0x040004BD RID: 1213
			private static readonly IntPtr NativeFieldInfoPtr_m_top;

			// Token: 0x040004BE RID: 1214
			private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_AllocatorHandle_0;

			// Token: 0x040004BF RID: 1215
			private static readonly IntPtr NativeMethodInfoPtr_Try_Public_Virtual_Final_New_Int32_byref_Block_0;

			// Token: 0x040004C0 RID: 1216
			private static readonly IntPtr NativeMethodInfoPtr_Try_Public_Static_Int32_IntPtr_byref_Block_0;

			// Token: 0x040004C1 RID: 1217
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040004C2 RID: 1218
			private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Int32_IntPtr_byref_Block_PDM_0;

			// Token: 0x040004C3 RID: 1219
			[FieldOffset(0)]
			public AllocatorManager.AllocatorHandle m_handle;

			// Token: 0x040004C4 RID: 1220
			[FieldOffset(8)]
			public AllocatorManager.Block m_storage;

			// Token: 0x040004C5 RID: 1221
			[FieldOffset(40)]
			public long m_top;

			// Token: 0x02000063 RID: 99
			[ObfuscatedName("Unity.Collections.AllocatorManager+StackAllocator+Try_00000950$PostfixBurstDelegate")]
			public sealed class MulticastDelegateNPublicSealedInObInUnique : MulticastDelegate
			{
				// Token: 0x06000320 RID: 800 RVA: 0x000122F8 File Offset: 0x000104F8
				// Note: this type is marked as 'beforefieldinit'.
				static MulticastDelegateNPublicSealedInObInUnique()
				{
					Il2CppClassPointerStore<AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager.StackAllocator>.NativeClassPtr, "Try_00000950$PostfixBurstDelegate");
					AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr, 100663343);
					AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr, 100663344);
					AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Block_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr, 100663345);
					AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr, 100663346);
				}

				// Token: 0x06000321 RID: 801 RVA: 0x0001236C File Offset: 0x0001056C
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe MulticastDelegateNPublicSealedInObInUnique(Object A_1, IntPtr A_2)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000322 RID: 802 RVA: 0x000123C8 File Offset: 0x000105C8
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 439745, RefRangeEnd = 439748, XrefRangeStart = 439745, XrefRangeEnd = 439748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int Invoke(IntPtr allocatorState, ref AllocatorManager.Block block)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref allocatorState;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_byref_Block_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06000323 RID: 803 RVA: 0x00012420 File Offset: 0x00010620
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439825, XrefRangeEnd = 439832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr allocatorState, ref AllocatorManager.Block block, AsyncCallback A_3, Object A_4)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref allocatorState;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Block_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06000324 RID: 804 RVA: 0x000124A0 File Offset: 0x000106A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int EndInvoke(IAsyncResult A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06000325 RID: 805 RVA: 0x00003590 File Offset: 0x00001790
				public MulticastDelegateNPublicSealedInObInUnique(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0400055F RID: 1375
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04000560 RID: 1376
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_byref_Block_0;

				// Token: 0x04000561 RID: 1377
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Block_AsyncCallback_Object_0;

				// Token: 0x04000562 RID: 1378
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
			}

			// Token: 0x02000064 RID: 100
			[ObfuscatedName("Unity.Collections.AllocatorManager+StackAllocator+Try_00000950$BurstDirectCall")]
			public static class ObjectNPrivateAbstractSealedInPoUnique : Object
			{
				// Token: 0x06000326 RID: 806 RVA: 0x000124F0 File Offset: 0x000106F0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectNPrivateAbstractSealedInPoUnique()
				{
					Il2CppClassPointerStore<AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager.StackAllocator>.NativeClassPtr, "Try_00000950$BurstDirectCall");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr);
					AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, "Pointer");
					AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663347);
					AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663348);
					AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663349);
					AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663350);
					AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Invoke_Public_Static_Int32_IntPtr_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663352);
				}

				// Token: 0x06000327 RID: 807 RVA: 0x00012594 File Offset: 0x00010794
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439832, XrefRangeEnd = 439848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static void GetFunctionPointerDiscard(ref IntPtr A_0)
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &A_0;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06000328 RID: 808 RVA: 0x000125C8 File Offset: 0x000107C8
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 439868, RefRangeEnd = 439871, XrefRangeStart = 439848, XrefRangeEnd = 439868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static IntPtr GetFunctionPointer()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06000329 RID: 809 RVA: 0x000125F8 File Offset: 0x000107F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439871, XrefRangeEnd = 439876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static void Constructor()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600032A RID: 810 RVA: 0x00012620 File Offset: 0x00010820
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439876, XrefRangeEnd = 439880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static void Initialize()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600032B RID: 811 RVA: 0x00012648 File Offset: 0x00010848
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439880, XrefRangeEnd = 439889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static int Invoke(IntPtr allocatorState, ref AllocatorManager.Block block)
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref allocatorState;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Invoke_Public_Static_Int32_IntPtr_byref_Block_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600032C RID: 812 RVA: 0x00003599 File Offset: 0x00001799
				public ObjectNPrivateAbstractSealedInPoUnique(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170000AA RID: 170
				// (get) Token: 0x0600032D RID: 813 RVA: 0x00012694 File Offset: 0x00010894
				// (set) Token: 0x0600032E RID: 814 RVA: 0x000035A2 File Offset: 0x000017A2
				public unsafe static IntPtr Pointer
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeFieldInfoPtr_Pointer, (void*)(&intPtr));
						return intPtr;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(AllocatorManager.StackAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeFieldInfoPtr_Pointer, (void*)(&value));
					}
				}

				// Token: 0x04000563 RID: 1379
				private static readonly IntPtr NativeFieldInfoPtr_Pointer;

				// Token: 0x04000564 RID: 1380
				private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

				// Token: 0x04000565 RID: 1381
				private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

				// Token: 0x04000566 RID: 1382
				private static readonly IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;

				// Token: 0x04000567 RID: 1383
				private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

				// Token: 0x04000568 RID: 1384
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Int32_IntPtr_byref_Block_0;
			}
		}

		// Token: 0x0200003A RID: 58
		public sealed class SlabAllocator : ValueType
		{
			// Token: 0x06000226 RID: 550 RVA: 0x0000E8BC File Offset: 0x0000CABC
			// Note: this type is marked as 'beforefieldinit'.
			static SlabAllocator()
			{
				Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "SlabAllocator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr);
				AllocatorManager.SlabAllocator.NativeFieldInfoPtr_m_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, "m_handle");
				AllocatorManager.SlabAllocator.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, "Storage");
				AllocatorManager.SlabAllocator.NativeFieldInfoPtr_Log2SlabSizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, "Log2SlabSizeInBytes");
				AllocatorManager.SlabAllocator.NativeFieldInfoPtr_Occupied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, "Occupied");
				AllocatorManager.SlabAllocator.NativeFieldInfoPtr_budgetInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, "budgetInBytes");
				AllocatorManager.SlabAllocator.NativeFieldInfoPtr_allocatedBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, "allocatedBytes");
				AllocatorManager.SlabAllocator.NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_AllocatorHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, 100663353);
				AllocatorManager.SlabAllocator.NativeMethodInfoPtr_get_SlabSizeInBytes_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, 100663354);
				AllocatorManager.SlabAllocator.NativeMethodInfoPtr_Try_Public_Virtual_Final_New_Int32_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, 100663355);
				AllocatorManager.SlabAllocator.NativeMethodInfoPtr_Try_Public_Static_Int32_IntPtr_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, 100663356);
				AllocatorManager.SlabAllocator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, 100663357);
				AllocatorManager.SlabAllocator.NativeMethodInfoPtr_Method_Public_Static_Int32_IntPtr_byref_Block_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, 100663358);
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000227 RID: 551 RVA: 0x0000E9D8 File Offset: 0x0000CBD8
			public unsafe AllocatorManager.AllocatorHandle Handle
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_AllocatorHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x06000228 RID: 552 RVA: 0x0000EA1C File Offset: 0x0000CC1C
			public unsafe int SlabSizeInBytes
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.NativeMethodInfoPtr_get_SlabSizeInBytes_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000229 RID: 553 RVA: 0x0000EA60 File Offset: 0x0000CC60
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 440010, RefRangeEnd = 440013, XrefRangeStart = 439998, XrefRangeEnd = 440010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Try(ref AllocatorManager.Block block)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &block;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.NativeMethodInfoPtr_Try_Public_Virtual_Final_New_Int32_byref_Block_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600022A RID: 554 RVA: 0x0000EAB0 File Offset: 0x0000CCB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440013, XrefRangeEnd = 440025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int Try(IntPtr allocatorState, ref AllocatorManager.Block block)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref allocatorState;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.NativeMethodInfoPtr_Try_Public_Static_Int32_IntPtr_byref_Block_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600022B RID: 555 RVA: 0x0000EAFC File Offset: 0x0000CCFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440025, XrefRangeEnd = 440053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600022C RID: 556 RVA: 0x0000EB34 File Offset: 0x0000CD34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440053, XrefRangeEnd = 440054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int Method_Public_Static_Int32_IntPtr_byref_Block_PDM_0(IntPtr allocatorState, ref AllocatorManager.Block block)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref allocatorState;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.NativeMethodInfoPtr_Method_Public_Static_Int32_IntPtr_byref_Block_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600022D RID: 557 RVA: 0x00002BB8 File Offset: 0x00000DB8
			public SlabAllocator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600022E RID: 558 RVA: 0x00002BC1 File Offset: 0x00000DC1
			public SlabAllocator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr))
			{
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x0600022F RID: 559 RVA: 0x0000EB80 File Offset: 0x0000CD80
			// (set) Token: 0x06000230 RID: 560 RVA: 0x00002BD3 File Offset: 0x00000DD3
			public unsafe AllocatorManager.AllocatorHandle m_handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.SlabAllocator.NativeFieldInfoPtr_m_handle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.SlabAllocator.NativeFieldInfoPtr_m_handle)) = value;
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000231 RID: 561 RVA: 0x0000EBA8 File Offset: 0x0000CDA8
			// (set) Token: 0x06000232 RID: 562 RVA: 0x00002BEE File Offset: 0x00000DEE
			public unsafe AllocatorManager.Block Storage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.SlabAllocator.NativeFieldInfoPtr_Storage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.SlabAllocator.NativeFieldInfoPtr_Storage)) = value;
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000233 RID: 563 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
			// (set) Token: 0x06000234 RID: 564 RVA: 0x00002C09 File Offset: 0x00000E09
			public unsafe int Log2SlabSizeInBytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.SlabAllocator.NativeFieldInfoPtr_Log2SlabSizeInBytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.SlabAllocator.NativeFieldInfoPtr_Log2SlabSizeInBytes)) = value;
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000235 RID: 565 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
			// (set) Token: 0x06000236 RID: 566 RVA: 0x00002C24 File Offset: 0x00000E24
			public FixedList4096Bytes<int> Occupied
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.SlabAllocator.NativeFieldInfoPtr_Occupied);
					return new FixedList4096Bytes<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FixedList4096Bytes<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.SlabAllocator.NativeFieldInfoPtr_Occupied), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FixedList4096Bytes<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000237 RID: 567 RVA: 0x0000EC28 File Offset: 0x0000CE28
			// (set) Token: 0x06000238 RID: 568 RVA: 0x00002C52 File Offset: 0x00000E52
			public unsafe long budgetInBytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.SlabAllocator.NativeFieldInfoPtr_budgetInBytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.SlabAllocator.NativeFieldInfoPtr_budgetInBytes)) = value;
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x06000239 RID: 569 RVA: 0x0000EC50 File Offset: 0x0000CE50
			// (set) Token: 0x0600023A RID: 570 RVA: 0x00002C6D File Offset: 0x00000E6D
			public unsafe long allocatedBytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.SlabAllocator.NativeFieldInfoPtr_allocatedBytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.SlabAllocator.NativeFieldInfoPtr_allocatedBytes)) = value;
				}
			}

			// Token: 0x040004C6 RID: 1222
			private static readonly IntPtr NativeFieldInfoPtr_m_handle;

			// Token: 0x040004C7 RID: 1223
			private static readonly IntPtr NativeFieldInfoPtr_Storage;

			// Token: 0x040004C8 RID: 1224
			private static readonly IntPtr NativeFieldInfoPtr_Log2SlabSizeInBytes;

			// Token: 0x040004C9 RID: 1225
			private static readonly IntPtr NativeFieldInfoPtr_Occupied;

			// Token: 0x040004CA RID: 1226
			private static readonly IntPtr NativeFieldInfoPtr_budgetInBytes;

			// Token: 0x040004CB RID: 1227
			private static readonly IntPtr NativeFieldInfoPtr_allocatedBytes;

			// Token: 0x040004CC RID: 1228
			private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_Virtual_Final_New_get_AllocatorHandle_0;

			// Token: 0x040004CD RID: 1229
			private static readonly IntPtr NativeMethodInfoPtr_get_SlabSizeInBytes_Internal_get_Int32_0;

			// Token: 0x040004CE RID: 1230
			private static readonly IntPtr NativeMethodInfoPtr_Try_Public_Virtual_Final_New_Int32_byref_Block_0;

			// Token: 0x040004CF RID: 1231
			private static readonly IntPtr NativeMethodInfoPtr_Try_Public_Static_Int32_IntPtr_byref_Block_0;

			// Token: 0x040004D0 RID: 1232
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040004D1 RID: 1233
			private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Static_Int32_IntPtr_byref_Block_PDM_0;

			// Token: 0x02000065 RID: 101
			[ObfuscatedName("Unity.Collections.AllocatorManager+SlabAllocator+Try_0000095E$PostfixBurstDelegate")]
			public sealed class MulticastDelegateNPublicSealedInObInUnique : MulticastDelegate
			{
				// Token: 0x0600032F RID: 815 RVA: 0x000126B0 File Offset: 0x000108B0
				// Note: this type is marked as 'beforefieldinit'.
				static MulticastDelegateNPublicSealedInObInUnique()
				{
					Il2CppClassPointerStore<AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, "Try_0000095E$PostfixBurstDelegate");
					AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr, 100663359);
					AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr, 100663360);
					AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Block_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr, 100663361);
					AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr, 100663362);
				}

				// Token: 0x06000330 RID: 816 RVA: 0x00012724 File Offset: 0x00010924
				[CallerCount(42)]
				[CachedScanResults(RefRangeStart = 403, RefRangeEnd = 445, XrefRangeStart = 403, XrefRangeEnd = 445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe MulticastDelegateNPublicSealedInObInUnique(Object A_1, IntPtr A_2)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000331 RID: 817 RVA: 0x00012780 File Offset: 0x00010980
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 439745, RefRangeEnd = 439748, XrefRangeStart = 439745, XrefRangeEnd = 439748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int Invoke(IntPtr allocatorState, ref AllocatorManager.Block block)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref allocatorState;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_byref_Block_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06000332 RID: 818 RVA: 0x000127D8 File Offset: 0x000109D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439934, XrefRangeEnd = 439941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr allocatorState, ref AllocatorManager.Block block, AsyncCallback A_3, Object A_4)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref allocatorState;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_3);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(A_4);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Block_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06000333 RID: 819 RVA: 0x00012858 File Offset: 0x00010A58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe int EndInvoke(IAsyncResult A_1)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(A_1);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.MulticastDelegateNPublicSealedInObInUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06000334 RID: 820 RVA: 0x000035B0 File Offset: 0x000017B0
				public MulticastDelegateNPublicSealedInObInUnique(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04000569 RID: 1385
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400056A RID: 1386
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_byref_Block_0;

				// Token: 0x0400056B RID: 1387
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Block_AsyncCallback_Object_0;

				// Token: 0x0400056C RID: 1388
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
			}

			// Token: 0x02000066 RID: 102
			[ObfuscatedName("Unity.Collections.AllocatorManager+SlabAllocator+Try_0000095E$BurstDirectCall")]
			public static class ObjectNPrivateAbstractSealedInPoUnique : Object
			{
				// Token: 0x06000335 RID: 821 RVA: 0x000128A8 File Offset: 0x00010AA8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectNPrivateAbstractSealedInPoUnique()
				{
					Il2CppClassPointerStore<AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager.SlabAllocator>.NativeClassPtr, "Try_0000095E$BurstDirectCall");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr);
					AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, "Pointer");
					AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663363);
					AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663364);
					AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663365);
					AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663366);
					AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Invoke_Public_Static_Int32_IntPtr_byref_Block_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique>.NativeClassPtr, 100663368);
				}

				// Token: 0x06000336 RID: 822 RVA: 0x0001294C File Offset: 0x00010B4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439941, XrefRangeEnd = 439957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static void GetFunctionPointerDiscard(ref IntPtr A_0)
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &A_0;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06000337 RID: 823 RVA: 0x00012980 File Offset: 0x00010B80
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 439977, RefRangeEnd = 439980, XrefRangeStart = 439957, XrefRangeEnd = 439977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static IntPtr GetFunctionPointer()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06000338 RID: 824 RVA: 0x000129B0 File Offset: 0x00010BB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439980, XrefRangeEnd = 439985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static void Constructor()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000339 RID: 825 RVA: 0x000129D8 File Offset: 0x00010BD8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439985, XrefRangeEnd = 439989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static void Initialize()
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600033A RID: 826 RVA: 0x00012A00 File Offset: 0x00010C00
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 439989, XrefRangeEnd = 439998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe static int Invoke(IntPtr allocatorState, ref AllocatorManager.Block block)
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref allocatorState;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &block;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeMethodInfoPtr_Invoke_Public_Static_Int32_IntPtr_byref_Block_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600033B RID: 827 RVA: 0x000035B9 File Offset: 0x000017B9
				public ObjectNPrivateAbstractSealedInPoUnique(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170000AB RID: 171
				// (get) Token: 0x0600033C RID: 828 RVA: 0x00012A4C File Offset: 0x00010C4C
				// (set) Token: 0x0600033D RID: 829 RVA: 0x000035C2 File Offset: 0x000017C2
				public unsafe static IntPtr Pointer
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeFieldInfoPtr_Pointer, (void*)(&intPtr));
						return intPtr;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(AllocatorManager.SlabAllocator.ObjectNPrivateAbstractSealedInPoUnique.NativeFieldInfoPtr_Pointer, (void*)(&value));
					}
				}

				// Token: 0x0400056D RID: 1389
				private static readonly IntPtr NativeFieldInfoPtr_Pointer;

				// Token: 0x0400056E RID: 1390
				private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;

				// Token: 0x0400056F RID: 1391
				private static readonly IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;

				// Token: 0x04000570 RID: 1392
				private static readonly IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;

				// Token: 0x04000571 RID: 1393
				private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

				// Token: 0x04000572 RID: 1394
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Int32_IntPtr_byref_Block_0;
			}
		}

		// Token: 0x0200003B RID: 59
		[StructLayout(2)]
		public struct TableEntry
		{
			// Token: 0x0600023B RID: 571 RVA: 0x0000EC78 File Offset: 0x0000CE78
			// Note: this type is marked as 'beforefieldinit'.
			static TableEntry()
			{
				Il2CppClassPointerStore<AllocatorManager.TableEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "TableEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.TableEntry>.NativeClassPtr);
				AllocatorManager.TableEntry.NativeFieldInfoPtr_function = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.TableEntry>.NativeClassPtr, "function");
				AllocatorManager.TableEntry.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.TableEntry>.NativeClassPtr, "state");
			}

			// Token: 0x0600023C RID: 572 RVA: 0x00002C88 File Offset: 0x00000E88
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.TableEntry>.NativeClassPtr, ref this));
			}

			// Token: 0x040004D2 RID: 1234
			private static readonly IntPtr NativeFieldInfoPtr_function;

			// Token: 0x040004D3 RID: 1235
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x040004D4 RID: 1236
			[FieldOffset(0)]
			public IntPtr function;

			// Token: 0x040004D5 RID: 1237
			[FieldOffset(8)]
			public IntPtr state;
		}

		// Token: 0x0200003C RID: 60
		public sealed class Array16<T> : ValueType where T : new()
		{
			// Token: 0x0600023D RID: 573 RVA: 0x0000ECCC File Offset: 0x0000CECC
			// Note: this type is marked as 'beforefieldinit'.
			static Array16()
			{
				Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "Array16`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr);
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f0");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f1");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f2");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f3");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f4");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f5");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f6");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f7");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f8");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f9");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f10");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f11");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f12");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f13");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f14");
				AllocatorManager.Array16<T>.NativeFieldInfoPtr_f15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, "f15");
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00002C9A File Offset: 0x00000E9A
			public Array16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600023F RID: 575 RVA: 0x00002CA3 File Offset: 0x00000EA3
			public Array16()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr))
			{
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000240 RID: 576 RVA: 0x0000EE74 File Offset: 0x0000D074
			// (set) Token: 0x06000241 RID: 577 RVA: 0x0000EE9C File Offset: 0x0000D09C
			public unsafe T f0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f0);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f0);
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

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x06000242 RID: 578 RVA: 0x0000EF44 File Offset: 0x0000D144
			// (set) Token: 0x06000243 RID: 579 RVA: 0x0000EF6C File Offset: 0x0000D16C
			public unsafe T f1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f1);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f1);
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

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000244 RID: 580 RVA: 0x0000F014 File Offset: 0x0000D214
			// (set) Token: 0x06000245 RID: 581 RVA: 0x0000F03C File Offset: 0x0000D23C
			public unsafe T f2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f2);
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

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x06000246 RID: 582 RVA: 0x0000F0E4 File Offset: 0x0000D2E4
			// (set) Token: 0x06000247 RID: 583 RVA: 0x0000F10C File Offset: 0x0000D30C
			public unsafe T f3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f3);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f3);
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

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x06000248 RID: 584 RVA: 0x0000F1B4 File Offset: 0x0000D3B4
			// (set) Token: 0x06000249 RID: 585 RVA: 0x0000F1DC File Offset: 0x0000D3DC
			public unsafe T f4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f4);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f4);
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

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x0600024A RID: 586 RVA: 0x0000F284 File Offset: 0x0000D484
			// (set) Token: 0x0600024B RID: 587 RVA: 0x0000F2AC File Offset: 0x0000D4AC
			public unsafe T f5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f5);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f5);
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

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x0600024C RID: 588 RVA: 0x0000F354 File Offset: 0x0000D554
			// (set) Token: 0x0600024D RID: 589 RVA: 0x0000F37C File Offset: 0x0000D57C
			public unsafe T f6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f6);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f6);
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

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x0600024E RID: 590 RVA: 0x0000F424 File Offset: 0x0000D624
			// (set) Token: 0x0600024F RID: 591 RVA: 0x0000F44C File Offset: 0x0000D64C
			public unsafe T f7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f7);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f7);
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

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x06000250 RID: 592 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
			// (set) Token: 0x06000251 RID: 593 RVA: 0x0000F51C File Offset: 0x0000D71C
			public unsafe T f8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f8);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f8);
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

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x06000252 RID: 594 RVA: 0x0000F5C4 File Offset: 0x0000D7C4
			// (set) Token: 0x06000253 RID: 595 RVA: 0x0000F5EC File Offset: 0x0000D7EC
			public unsafe T f9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f9);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f9);
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

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x06000254 RID: 596 RVA: 0x0000F694 File Offset: 0x0000D894
			// (set) Token: 0x06000255 RID: 597 RVA: 0x0000F6BC File Offset: 0x0000D8BC
			public unsafe T f10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f10);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f10);
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

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x06000256 RID: 598 RVA: 0x0000F764 File Offset: 0x0000D964
			// (set) Token: 0x06000257 RID: 599 RVA: 0x0000F78C File Offset: 0x0000D98C
			public unsafe T f11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f11);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f11);
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

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x06000258 RID: 600 RVA: 0x0000F834 File Offset: 0x0000DA34
			// (set) Token: 0x06000259 RID: 601 RVA: 0x0000F85C File Offset: 0x0000DA5C
			public unsafe T f12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f12);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f12);
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

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x0600025A RID: 602 RVA: 0x0000F904 File Offset: 0x0000DB04
			// (set) Token: 0x0600025B RID: 603 RVA: 0x0000F92C File Offset: 0x0000DB2C
			public unsafe T f13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f13);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f13);
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

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x0600025C RID: 604 RVA: 0x0000F9D4 File Offset: 0x0000DBD4
			// (set) Token: 0x0600025D RID: 605 RVA: 0x0000F9FC File Offset: 0x0000DBFC
			public unsafe T f14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f14);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f14);
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

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x0600025E RID: 606 RVA: 0x0000FAA4 File Offset: 0x0000DCA4
			// (set) Token: 0x0600025F RID: 607 RVA: 0x0000FACC File Offset: 0x0000DCCC
			public unsafe T f15
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f15);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array16<T>.NativeFieldInfoPtr_f15);
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

			// Token: 0x040004D6 RID: 1238
			private static readonly IntPtr NativeFieldInfoPtr_f0;

			// Token: 0x040004D7 RID: 1239
			private static readonly IntPtr NativeFieldInfoPtr_f1;

			// Token: 0x040004D8 RID: 1240
			private static readonly IntPtr NativeFieldInfoPtr_f2;

			// Token: 0x040004D9 RID: 1241
			private static readonly IntPtr NativeFieldInfoPtr_f3;

			// Token: 0x040004DA RID: 1242
			private static readonly IntPtr NativeFieldInfoPtr_f4;

			// Token: 0x040004DB RID: 1243
			private static readonly IntPtr NativeFieldInfoPtr_f5;

			// Token: 0x040004DC RID: 1244
			private static readonly IntPtr NativeFieldInfoPtr_f6;

			// Token: 0x040004DD RID: 1245
			private static readonly IntPtr NativeFieldInfoPtr_f7;

			// Token: 0x040004DE RID: 1246
			private static readonly IntPtr NativeFieldInfoPtr_f8;

			// Token: 0x040004DF RID: 1247
			private static readonly IntPtr NativeFieldInfoPtr_f9;

			// Token: 0x040004E0 RID: 1248
			private static readonly IntPtr NativeFieldInfoPtr_f10;

			// Token: 0x040004E1 RID: 1249
			private static readonly IntPtr NativeFieldInfoPtr_f11;

			// Token: 0x040004E2 RID: 1250
			private static readonly IntPtr NativeFieldInfoPtr_f12;

			// Token: 0x040004E3 RID: 1251
			private static readonly IntPtr NativeFieldInfoPtr_f13;

			// Token: 0x040004E4 RID: 1252
			private static readonly IntPtr NativeFieldInfoPtr_f14;

			// Token: 0x040004E5 RID: 1253
			private static readonly IntPtr NativeFieldInfoPtr_f15;
		}

		// Token: 0x0200003D RID: 61
		public sealed class Array256<T> : ValueType where T : new()
		{
			// Token: 0x06000260 RID: 608 RVA: 0x0000FB74 File Offset: 0x0000DD74
			// Note: this type is marked as 'beforefieldinit'.
			static Array256()
			{
				Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "Array256`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr);
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f0");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f1");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f2");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f3");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f4");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f5");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f6");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f7");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f8");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f9");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f10");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f11");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f12");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f13");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f14");
				AllocatorManager.Array256<T>.NativeFieldInfoPtr_f15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, "f15");
			}

			// Token: 0x06000261 RID: 609 RVA: 0x00002CB5 File Offset: 0x00000EB5
			public Array256(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000262 RID: 610 RVA: 0x00002CBE File Offset: 0x00000EBE
			public Array256()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr))
			{
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000263 RID: 611 RVA: 0x0000FD1C File Offset: 0x0000DF1C
			// (set) Token: 0x06000264 RID: 612 RVA: 0x00002CD0 File Offset: 0x00000ED0
			public AllocatorManager.Array16<T> f0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f0);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x06000265 RID: 613 RVA: 0x0000FD4C File Offset: 0x0000DF4C
			// (set) Token: 0x06000266 RID: 614 RVA: 0x00002CFE File Offset: 0x00000EFE
			public AllocatorManager.Array16<T> f1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f1);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x06000267 RID: 615 RVA: 0x0000FD7C File Offset: 0x0000DF7C
			// (set) Token: 0x06000268 RID: 616 RVA: 0x00002D2C File Offset: 0x00000F2C
			public AllocatorManager.Array16<T> f2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f2);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x06000269 RID: 617 RVA: 0x0000FDAC File Offset: 0x0000DFAC
			// (set) Token: 0x0600026A RID: 618 RVA: 0x00002D5A File Offset: 0x00000F5A
			public AllocatorManager.Array16<T> f3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f3);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x0600026B RID: 619 RVA: 0x0000FDDC File Offset: 0x0000DFDC
			// (set) Token: 0x0600026C RID: 620 RVA: 0x00002D88 File Offset: 0x00000F88
			public AllocatorManager.Array16<T> f4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f4);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x0600026D RID: 621 RVA: 0x0000FE0C File Offset: 0x0000E00C
			// (set) Token: 0x0600026E RID: 622 RVA: 0x00002DB6 File Offset: 0x00000FB6
			public AllocatorManager.Array16<T> f5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f5);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x0600026F RID: 623 RVA: 0x0000FE3C File Offset: 0x0000E03C
			// (set) Token: 0x06000270 RID: 624 RVA: 0x00002DE4 File Offset: 0x00000FE4
			public AllocatorManager.Array16<T> f6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f6);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x06000271 RID: 625 RVA: 0x0000FE6C File Offset: 0x0000E06C
			// (set) Token: 0x06000272 RID: 626 RVA: 0x00002E12 File Offset: 0x00001012
			public AllocatorManager.Array16<T> f7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f7);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f7), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x06000273 RID: 627 RVA: 0x0000FE9C File Offset: 0x0000E09C
			// (set) Token: 0x06000274 RID: 628 RVA: 0x00002E40 File Offset: 0x00001040
			public AllocatorManager.Array16<T> f8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f8);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f8), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x06000275 RID: 629 RVA: 0x0000FECC File Offset: 0x0000E0CC
			// (set) Token: 0x06000276 RID: 630 RVA: 0x00002E6E File Offset: 0x0000106E
			public AllocatorManager.Array16<T> f9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f9);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f9), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x06000277 RID: 631 RVA: 0x0000FEFC File Offset: 0x0000E0FC
			// (set) Token: 0x06000278 RID: 632 RVA: 0x00002E9C File Offset: 0x0000109C
			public AllocatorManager.Array16<T> f10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f10);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f10), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x06000279 RID: 633 RVA: 0x0000FF2C File Offset: 0x0000E12C
			// (set) Token: 0x0600027A RID: 634 RVA: 0x00002ECA File Offset: 0x000010CA
			public AllocatorManager.Array16<T> f11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f11);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f11), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x0600027B RID: 635 RVA: 0x0000FF5C File Offset: 0x0000E15C
			// (set) Token: 0x0600027C RID: 636 RVA: 0x00002EF8 File Offset: 0x000010F8
			public AllocatorManager.Array16<T> f12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f12);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f12), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x0600027D RID: 637 RVA: 0x0000FF8C File Offset: 0x0000E18C
			// (set) Token: 0x0600027E RID: 638 RVA: 0x00002F26 File Offset: 0x00001126
			public AllocatorManager.Array16<T> f13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f13);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f13), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x0600027F RID: 639 RVA: 0x0000FFBC File Offset: 0x0000E1BC
			// (set) Token: 0x06000280 RID: 640 RVA: 0x00002F54 File Offset: 0x00001154
			public AllocatorManager.Array16<T> f14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f14);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f14), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000281 RID: 641 RVA: 0x0000FFEC File Offset: 0x0000E1EC
			// (set) Token: 0x06000282 RID: 642 RVA: 0x00002F82 File Offset: 0x00001182
			public AllocatorManager.Array16<T> f15
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f15);
					return new AllocatorManager.Array16<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array256<T>.NativeFieldInfoPtr_f15), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array16<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040004E6 RID: 1254
			private static readonly IntPtr NativeFieldInfoPtr_f0;

			// Token: 0x040004E7 RID: 1255
			private static readonly IntPtr NativeFieldInfoPtr_f1;

			// Token: 0x040004E8 RID: 1256
			private static readonly IntPtr NativeFieldInfoPtr_f2;

			// Token: 0x040004E9 RID: 1257
			private static readonly IntPtr NativeFieldInfoPtr_f3;

			// Token: 0x040004EA RID: 1258
			private static readonly IntPtr NativeFieldInfoPtr_f4;

			// Token: 0x040004EB RID: 1259
			private static readonly IntPtr NativeFieldInfoPtr_f5;

			// Token: 0x040004EC RID: 1260
			private static readonly IntPtr NativeFieldInfoPtr_f6;

			// Token: 0x040004ED RID: 1261
			private static readonly IntPtr NativeFieldInfoPtr_f7;

			// Token: 0x040004EE RID: 1262
			private static readonly IntPtr NativeFieldInfoPtr_f8;

			// Token: 0x040004EF RID: 1263
			private static readonly IntPtr NativeFieldInfoPtr_f9;

			// Token: 0x040004F0 RID: 1264
			private static readonly IntPtr NativeFieldInfoPtr_f10;

			// Token: 0x040004F1 RID: 1265
			private static readonly IntPtr NativeFieldInfoPtr_f11;

			// Token: 0x040004F2 RID: 1266
			private static readonly IntPtr NativeFieldInfoPtr_f12;

			// Token: 0x040004F3 RID: 1267
			private static readonly IntPtr NativeFieldInfoPtr_f13;

			// Token: 0x040004F4 RID: 1268
			private static readonly IntPtr NativeFieldInfoPtr_f14;

			// Token: 0x040004F5 RID: 1269
			private static readonly IntPtr NativeFieldInfoPtr_f15;
		}

		// Token: 0x0200003E RID: 62
		public sealed class Array4096<T> : ValueType where T : new()
		{
			// Token: 0x06000283 RID: 643 RVA: 0x0001001C File Offset: 0x0000E21C
			// Note: this type is marked as 'beforefieldinit'.
			static Array4096()
			{
				Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "Array4096`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr);
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f0");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f1");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f2");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f3");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f4");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f5");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f6");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f7");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f8");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f9");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f10");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f11");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f12");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f13");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f14");
				AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, "f15");
			}

			// Token: 0x06000284 RID: 644 RVA: 0x00002FB0 File Offset: 0x000011B0
			public Array4096(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000285 RID: 645 RVA: 0x00002FB9 File Offset: 0x000011B9
			public Array4096()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr))
			{
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000286 RID: 646 RVA: 0x000101C4 File Offset: 0x0000E3C4
			// (set) Token: 0x06000287 RID: 647 RVA: 0x00002FCB File Offset: 0x000011CB
			public AllocatorManager.Array256<T> f0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f0);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x06000288 RID: 648 RVA: 0x000101F4 File Offset: 0x0000E3F4
			// (set) Token: 0x06000289 RID: 649 RVA: 0x00002FF9 File Offset: 0x000011F9
			public AllocatorManager.Array256<T> f1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f1);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x0600028A RID: 650 RVA: 0x00010224 File Offset: 0x0000E424
			// (set) Token: 0x0600028B RID: 651 RVA: 0x00003027 File Offset: 0x00001227
			public AllocatorManager.Array256<T> f2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f2);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x0600028C RID: 652 RVA: 0x00010254 File Offset: 0x0000E454
			// (set) Token: 0x0600028D RID: 653 RVA: 0x00003055 File Offset: 0x00001255
			public AllocatorManager.Array256<T> f3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f3);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x0600028E RID: 654 RVA: 0x00010284 File Offset: 0x0000E484
			// (set) Token: 0x0600028F RID: 655 RVA: 0x00003083 File Offset: 0x00001283
			public AllocatorManager.Array256<T> f4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f4);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x06000290 RID: 656 RVA: 0x000102B4 File Offset: 0x0000E4B4
			// (set) Token: 0x06000291 RID: 657 RVA: 0x000030B1 File Offset: 0x000012B1
			public AllocatorManager.Array256<T> f5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f5);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x06000292 RID: 658 RVA: 0x000102E4 File Offset: 0x0000E4E4
			// (set) Token: 0x06000293 RID: 659 RVA: 0x000030DF File Offset: 0x000012DF
			public AllocatorManager.Array256<T> f6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f6);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x06000294 RID: 660 RVA: 0x00010314 File Offset: 0x0000E514
			// (set) Token: 0x06000295 RID: 661 RVA: 0x0000310D File Offset: 0x0000130D
			public AllocatorManager.Array256<T> f7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f7);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f7), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x06000296 RID: 662 RVA: 0x00010344 File Offset: 0x0000E544
			// (set) Token: 0x06000297 RID: 663 RVA: 0x0000313B File Offset: 0x0000133B
			public AllocatorManager.Array256<T> f8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f8);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f8), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x06000298 RID: 664 RVA: 0x00010374 File Offset: 0x0000E574
			// (set) Token: 0x06000299 RID: 665 RVA: 0x00003169 File Offset: 0x00001369
			public AllocatorManager.Array256<T> f9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f9);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f9), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x0600029A RID: 666 RVA: 0x000103A4 File Offset: 0x0000E5A4
			// (set) Token: 0x0600029B RID: 667 RVA: 0x00003197 File Offset: 0x00001397
			public AllocatorManager.Array256<T> f10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f10);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f10), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x0600029C RID: 668 RVA: 0x000103D4 File Offset: 0x0000E5D4
			// (set) Token: 0x0600029D RID: 669 RVA: 0x000031C5 File Offset: 0x000013C5
			public AllocatorManager.Array256<T> f11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f11);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f11), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x0600029E RID: 670 RVA: 0x00010404 File Offset: 0x0000E604
			// (set) Token: 0x0600029F RID: 671 RVA: 0x000031F3 File Offset: 0x000013F3
			public AllocatorManager.Array256<T> f12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f12);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f12), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060002A0 RID: 672 RVA: 0x00010434 File Offset: 0x0000E634
			// (set) Token: 0x060002A1 RID: 673 RVA: 0x00003221 File Offset: 0x00001421
			public AllocatorManager.Array256<T> f13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f13);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f13), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060002A2 RID: 674 RVA: 0x00010464 File Offset: 0x0000E664
			// (set) Token: 0x060002A3 RID: 675 RVA: 0x0000324F File Offset: 0x0000144F
			public AllocatorManager.Array256<T> f14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f14);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f14), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060002A4 RID: 676 RVA: 0x00010494 File Offset: 0x0000E694
			// (set) Token: 0x060002A5 RID: 677 RVA: 0x0000327D File Offset: 0x0000147D
			public AllocatorManager.Array256<T> f15
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f15);
					return new AllocatorManager.Array256<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array4096<T>.NativeFieldInfoPtr_f15), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array256<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040004F6 RID: 1270
			private static readonly IntPtr NativeFieldInfoPtr_f0;

			// Token: 0x040004F7 RID: 1271
			private static readonly IntPtr NativeFieldInfoPtr_f1;

			// Token: 0x040004F8 RID: 1272
			private static readonly IntPtr NativeFieldInfoPtr_f2;

			// Token: 0x040004F9 RID: 1273
			private static readonly IntPtr NativeFieldInfoPtr_f3;

			// Token: 0x040004FA RID: 1274
			private static readonly IntPtr NativeFieldInfoPtr_f4;

			// Token: 0x040004FB RID: 1275
			private static readonly IntPtr NativeFieldInfoPtr_f5;

			// Token: 0x040004FC RID: 1276
			private static readonly IntPtr NativeFieldInfoPtr_f6;

			// Token: 0x040004FD RID: 1277
			private static readonly IntPtr NativeFieldInfoPtr_f7;

			// Token: 0x040004FE RID: 1278
			private static readonly IntPtr NativeFieldInfoPtr_f8;

			// Token: 0x040004FF RID: 1279
			private static readonly IntPtr NativeFieldInfoPtr_f9;

			// Token: 0x04000500 RID: 1280
			private static readonly IntPtr NativeFieldInfoPtr_f10;

			// Token: 0x04000501 RID: 1281
			private static readonly IntPtr NativeFieldInfoPtr_f11;

			// Token: 0x04000502 RID: 1282
			private static readonly IntPtr NativeFieldInfoPtr_f12;

			// Token: 0x04000503 RID: 1283
			private static readonly IntPtr NativeFieldInfoPtr_f13;

			// Token: 0x04000504 RID: 1284
			private static readonly IntPtr NativeFieldInfoPtr_f14;

			// Token: 0x04000505 RID: 1285
			private static readonly IntPtr NativeFieldInfoPtr_f15;
		}

		// Token: 0x0200003F RID: 63
		public sealed class Array32768<T> : ValueType where T : new()
		{
			// Token: 0x060002A6 RID: 678 RVA: 0x000104C4 File Offset: 0x0000E6C4
			// Note: this type is marked as 'beforefieldinit'.
			static Array32768()
			{
				Il2CppClassPointerStore<AllocatorManager.Array32768<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "Array32768`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.Array32768<T>>.NativeClassPtr);
				AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array32768<T>>.NativeClassPtr, "f0");
				AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array32768<T>>.NativeClassPtr, "f1");
				AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array32768<T>>.NativeClassPtr, "f2");
				AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array32768<T>>.NativeClassPtr, "f3");
				AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array32768<T>>.NativeClassPtr, "f4");
				AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array32768<T>>.NativeClassPtr, "f5");
				AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array32768<T>>.NativeClassPtr, "f6");
				AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Array32768<T>>.NativeClassPtr, "f7");
				AllocatorManager.Array32768<T>.NativeMethodInfoPtr_ElementAt_Public_Virtual_Final_New_byref_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.Array32768<T>>.NativeClassPtr, 100663369);
			}

			// Token: 0x060002A7 RID: 679 RVA: 0x000105E0 File Offset: 0x0000E7E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440054, XrefRangeEnd = 440056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ref T ElementAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.Array32768<T>.NativeMethodInfoPtr_ElementAt_Public_Virtual_Final_New_byref_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x000032AB File Offset: 0x000014AB
			public Array32768(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x000032B4 File Offset: 0x000014B4
			public Array32768()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllocatorManager.Array32768<T>>.NativeClassPtr))
			{
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060002AA RID: 682 RVA: 0x00010624 File Offset: 0x0000E824
			// (set) Token: 0x060002AB RID: 683 RVA: 0x000032C6 File Offset: 0x000014C6
			public AllocatorManager.Array4096<T> f0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f0);
					return new AllocatorManager.Array4096<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060002AC RID: 684 RVA: 0x00010654 File Offset: 0x0000E854
			// (set) Token: 0x060002AD RID: 685 RVA: 0x000032F4 File Offset: 0x000014F4
			public AllocatorManager.Array4096<T> f1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f1);
					return new AllocatorManager.Array4096<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060002AE RID: 686 RVA: 0x00010684 File Offset: 0x0000E884
			// (set) Token: 0x060002AF RID: 687 RVA: 0x00003322 File Offset: 0x00001522
			public AllocatorManager.Array4096<T> f2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f2);
					return new AllocatorManager.Array4096<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060002B0 RID: 688 RVA: 0x000106B4 File Offset: 0x0000E8B4
			// (set) Token: 0x060002B1 RID: 689 RVA: 0x00003350 File Offset: 0x00001550
			public AllocatorManager.Array4096<T> f3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f3);
					return new AllocatorManager.Array4096<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060002B2 RID: 690 RVA: 0x000106E4 File Offset: 0x0000E8E4
			// (set) Token: 0x060002B3 RID: 691 RVA: 0x0000337E File Offset: 0x0000157E
			public AllocatorManager.Array4096<T> f4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f4);
					return new AllocatorManager.Array4096<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x060002B4 RID: 692 RVA: 0x00010714 File Offset: 0x0000E914
			// (set) Token: 0x060002B5 RID: 693 RVA: 0x000033AC File Offset: 0x000015AC
			public AllocatorManager.Array4096<T> f5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f5);
					return new AllocatorManager.Array4096<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x060002B6 RID: 694 RVA: 0x00010744 File Offset: 0x0000E944
			// (set) Token: 0x060002B7 RID: 695 RVA: 0x000033DA File Offset: 0x000015DA
			public AllocatorManager.Array4096<T> f6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f6);
					return new AllocatorManager.Array4096<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x060002B8 RID: 696 RVA: 0x00010774 File Offset: 0x0000E974
			// (set) Token: 0x060002B9 RID: 697 RVA: 0x00003408 File Offset: 0x00001608
			public AllocatorManager.Array4096<T> f7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f7);
					return new AllocatorManager.Array4096<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AllocatorManager.Array32768<T>.NativeFieldInfoPtr_f7), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AllocatorManager.Array4096<T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000506 RID: 1286
			private static readonly IntPtr NativeFieldInfoPtr_f0;

			// Token: 0x04000507 RID: 1287
			private static readonly IntPtr NativeFieldInfoPtr_f1;

			// Token: 0x04000508 RID: 1288
			private static readonly IntPtr NativeFieldInfoPtr_f2;

			// Token: 0x04000509 RID: 1289
			private static readonly IntPtr NativeFieldInfoPtr_f3;

			// Token: 0x0400050A RID: 1290
			private static readonly IntPtr NativeFieldInfoPtr_f4;

			// Token: 0x0400050B RID: 1291
			private static readonly IntPtr NativeFieldInfoPtr_f5;

			// Token: 0x0400050C RID: 1292
			private static readonly IntPtr NativeFieldInfoPtr_f6;

			// Token: 0x0400050D RID: 1293
			private static readonly IntPtr NativeFieldInfoPtr_f7;

			// Token: 0x0400050E RID: 1294
			private static readonly IntPtr NativeMethodInfoPtr_ElementAt_Public_Virtual_Final_New_byref_T_Int32_0;
		}

		// Token: 0x02000040 RID: 64
		public sealed class SharedStatics : Object
		{
			// Token: 0x060002BA RID: 698 RVA: 0x00003436 File Offset: 0x00001636
			// Note: this type is marked as 'beforefieldinit'.
			static SharedStatics()
			{
				Il2CppClassPointerStore<AllocatorManager.SharedStatics>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "SharedStatics");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.SharedStatics>.NativeClassPtr);
			}

			// Token: 0x060002BB RID: 699 RVA: 0x00003456 File Offset: 0x00001656
			public SharedStatics(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x02000067 RID: 103
			public sealed class IsInstalled : Object
			{
				// Token: 0x0600033E RID: 830 RVA: 0x000035D0 File Offset: 0x000017D0
				// Note: this type is marked as 'beforefieldinit'.
				static IsInstalled()
				{
					Il2CppClassPointerStore<AllocatorManager.SharedStatics.IsInstalled>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager.SharedStatics>.NativeClassPtr, "IsInstalled");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.SharedStatics.IsInstalled>.NativeClassPtr);
					AllocatorManager.SharedStatics.IsInstalled.NativeFieldInfoPtr_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.SharedStatics.IsInstalled>.NativeClassPtr, "Ref");
				}

				// Token: 0x0600033F RID: 831 RVA: 0x00003604 File Offset: 0x00001804
				public IsInstalled(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170000AC RID: 172
				// (get) Token: 0x06000340 RID: 832 RVA: 0x00012A68 File Offset: 0x00010C68
				// (set) Token: 0x06000341 RID: 833 RVA: 0x0000360D File Offset: 0x0000180D
				public unsafe static SharedStatic<Long1024> Ref
				{
					get
					{
						IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SharedStatic<Long1024>>.NativeClassPtr, (UIntPtr)0)];
						IL2CPP.il2cpp_field_static_get_value(AllocatorManager.SharedStatics.IsInstalled.NativeFieldInfoPtr_Ref, intPtr);
						return new SharedStatic<Long1024>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SharedStatic<Long1024>>.NativeClassPtr, intPtr));
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(AllocatorManager.SharedStatics.IsInstalled.NativeFieldInfoPtr_Ref, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
					}
				}

				// Token: 0x04000573 RID: 1395
				private static readonly IntPtr NativeFieldInfoPtr_Ref;
			}

			// Token: 0x02000068 RID: 104
			public sealed class TableEntry : Object
			{
				// Token: 0x06000342 RID: 834 RVA: 0x00003624 File Offset: 0x00001824
				// Note: this type is marked as 'beforefieldinit'.
				static TableEntry()
				{
					Il2CppClassPointerStore<AllocatorManager.SharedStatics.TableEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager.SharedStatics>.NativeClassPtr, "TableEntry");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.SharedStatics.TableEntry>.NativeClassPtr);
					AllocatorManager.SharedStatics.TableEntry.NativeFieldInfoPtr_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.SharedStatics.TableEntry>.NativeClassPtr, "Ref");
				}

				// Token: 0x06000343 RID: 835 RVA: 0x00003658 File Offset: 0x00001858
				public TableEntry(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170000AD RID: 173
				// (get) Token: 0x06000344 RID: 836 RVA: 0x00012AA4 File Offset: 0x00010CA4
				// (set) Token: 0x06000345 RID: 837 RVA: 0x00003661 File Offset: 0x00001861
				public unsafe static SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>> Ref
				{
					get
					{
						IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>>.NativeClassPtr, (UIntPtr)0)];
						IL2CPP.il2cpp_field_static_get_value(AllocatorManager.SharedStatics.TableEntry.NativeFieldInfoPtr_Ref, intPtr);
						return new SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SharedStatic<AllocatorManager.Array32768<AllocatorManager.TableEntry>>>.NativeClassPtr, intPtr));
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(AllocatorManager.SharedStatics.TableEntry.NativeFieldInfoPtr_Ref, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
					}
				}

				// Token: 0x04000574 RID: 1396
				private static readonly IntPtr NativeFieldInfoPtr_Ref;
			}
		}

		// Token: 0x02000041 RID: 65
		public static class Managed : Object
		{
			// Token: 0x060002BC RID: 700 RVA: 0x000107A4 File Offset: 0x0000E9A4
			// Note: this type is marked as 'beforefieldinit'.
			static Managed()
			{
				Il2CppClassPointerStore<AllocatorManager.Managed>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr, "Managed");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocatorManager.Managed>.NativeClassPtr);
				AllocatorManager.Managed.NativeFieldInfoPtr_TryFunctionDelegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocatorManager.Managed>.NativeClassPtr, "TryFunctionDelegates");
				AllocatorManager.Managed.NativeMethodInfoPtr_UnregisterDelegate_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocatorManager.Managed>.NativeClassPtr, 100663372);
			}

			// Token: 0x060002BD RID: 701 RVA: 0x000107F8 File Offset: 0x0000E9F8
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 440060, RefRangeEnd = 440065, XrefRangeStart = 440056, XrefRangeEnd = 440060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void UnregisterDelegate(int index)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllocatorManager.Managed.NativeMethodInfoPtr_UnregisterDelegate_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002BE RID: 702 RVA: 0x0000345F File Offset: 0x0000165F
			public Managed(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x060002BF RID: 703 RVA: 0x0001082C File Offset: 0x0000EA2C
			// (set) Token: 0x060002C0 RID: 704 RVA: 0x00003468 File Offset: 0x00001668
			public unsafe static Il2CppReferenceArray<AllocatorManager.TryFunction> TryFunctionDelegates
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AllocatorManager.Managed.NativeFieldInfoPtr_TryFunctionDelegates, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AllocatorManager.TryFunction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AllocatorManager.Managed.NativeFieldInfoPtr_TryFunctionDelegates, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400050F RID: 1295
			private static readonly IntPtr NativeFieldInfoPtr_TryFunctionDelegates;

			// Token: 0x04000510 RID: 1296
			private static readonly IntPtr NativeMethodInfoPtr_UnregisterDelegate_Public_Static_Void_Int32_0;
		}

		// Token: 0x02000042 RID: 66
		private sealed class MethodInfoStoreGeneric_AllocateBlock_Internal_Static_Block_byref_T_Int32_Int32_Int32_0<T>
		{
			// Token: 0x04000511 RID: 1297
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AllocatorManager.NativeMethodInfoPtr_AllocateBlock_Internal_Static_Block_byref_T_Int32_Int32_Int32_0, Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000043 RID: 67
		private sealed class MethodInfoStoreGeneric_Allocate_Internal_Static_ptr_Void_byref_T_Int32_Int32_Int32_0<T>
		{
			// Token: 0x04000512 RID: 1298
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AllocatorManager.NativeMethodInfoPtr_Allocate_Internal_Static_ptr_Void_byref_T_Int32_Int32_Int32_0, Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000044 RID: 68
		private sealed class MethodInfoStoreGeneric_Allocate_Internal_Static_ptr_U_byref_T_U_Int32_0<T, U>
		{
			// Token: 0x04000513 RID: 1299
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AllocatorManager.NativeMethodInfoPtr_Allocate_Internal_Static_ptr_U_byref_T_U_Int32_0, Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000045 RID: 69
		private sealed class MethodInfoStoreGeneric_FreeBlock_Internal_Static_Void_byref_T_byref_Block_0<T>
		{
			// Token: 0x04000514 RID: 1300
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AllocatorManager.NativeMethodInfoPtr_FreeBlock_Internal_Static_Void_byref_T_byref_Block_0, Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000046 RID: 70
		private sealed class MethodInfoStoreGeneric_Free_Internal_Static_Void_byref_T_ptr_Void_Int32_Int32_Int32_0<T>
		{
			// Token: 0x04000515 RID: 1301
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AllocatorManager.NativeMethodInfoPtr_Free_Internal_Static_Void_byref_T_ptr_Void_Int32_Int32_Int32_0, Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000047 RID: 71
		private sealed class MethodInfoStoreGeneric_Free_Internal_Static_Void_byref_T_ptr_U_Int32_0<T, U>
		{
			// Token: 0x04000516 RID: 1302
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AllocatorManager.NativeMethodInfoPtr_Free_Internal_Static_Void_byref_T_ptr_U_Int32_0, Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000048 RID: 72
		private sealed class MethodInfoStoreGeneric_Free_Public_Static_Void_AllocatorHandle_ptr_T_Int32_0<T>
		{
			// Token: 0x04000517 RID: 1303
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AllocatorManager.NativeMethodInfoPtr_Free_Public_Static_Void_AllocatorHandle_ptr_T_Int32_0, Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000049 RID: 73
		private sealed class MethodInfoStoreGeneric_Unregister_Public_Static_Void_byref_T_0<T>
		{
			// Token: 0x04000518 RID: 1304
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AllocatorManager.NativeMethodInfoPtr_Unregister_Public_Static_Void_byref_T_0, Il2CppClassPointerStore<AllocatorManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
