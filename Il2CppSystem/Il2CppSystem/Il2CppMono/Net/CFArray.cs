using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMono.Net
{
	// Token: 0x0200000D RID: 13
	public class CFArray : CFObject
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00012C44 File Offset: 0x00010E44
		// Note: this type is marked as 'beforefieldinit'.
		static CFArray()
		{
			Il2CppClassPointerStore<CFArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFArray");
			CFArray.NativeFieldInfoPtr_kCFTypeArrayCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFArray>.NativeClassPtr, "kCFTypeArrayCallbacks");
			CFArray.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFArray>.NativeClassPtr, 100663515);
			CFArray.NativeMethodInfoPtr_CFArrayGetCount_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFArray>.NativeClassPtr, 100663517);
			CFArray.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFArray>.NativeClassPtr, 100663518);
			CFArray.NativeMethodInfoPtr_CFArrayGetValueAtIndex_Private_Static_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFArray>.NativeClassPtr, 100663519);
			CFArray.NativeMethodInfoPtr_get_Item_Public_get_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFArray>.NativeClassPtr, 100663520);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00012CE4 File Offset: 0x00010EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364913, XrefRangeEnd = 364926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CFArray(IntPtr handle, bool own)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref own;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFArray.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00012D3C File Offset: 0x00010F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364926, XrefRangeEnd = 364928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFArrayGetCount(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFArray.NativeMethodInfoPtr_CFArrayGetCount_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00012D7C File Offset: 0x00010F7C
		public unsafe int Count
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 364933, RefRangeEnd = 364936, XrefRangeStart = 364928, XrefRangeEnd = 364933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFArray.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00012DB8 File Offset: 0x00010FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364936, XrefRangeEnd = 364938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFArrayGetValueAtIndex(IntPtr handle, IntPtr index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFArray.NativeMethodInfoPtr_CFArrayGetValueAtIndex_Private_Static_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700002A RID: 42
		public unsafe IntPtr this[int index]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 364959, RefRangeEnd = 364962, XrefRangeStart = 364938, XrefRangeEnd = 364959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFArray.NativeMethodInfoPtr_get_Item_Public_get_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000023A1 File Offset: 0x000005A1
		public CFArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00012E50 File Offset: 0x00011050
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000023AA File Offset: 0x000005AA
		public unsafe static IntPtr kCFTypeArrayCallbacks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CFArray.NativeFieldInfoPtr_kCFTypeArrayCallbacks, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CFArray.NativeFieldInfoPtr_kCFTypeArrayCallbacks, (void*)(&value));
			}
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_kCFTypeArrayCallbacks;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_CFArrayGetCount_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_CFArrayGetValueAtIndex_Private_Static_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_IntPtr_Int32_0;
	}
}
