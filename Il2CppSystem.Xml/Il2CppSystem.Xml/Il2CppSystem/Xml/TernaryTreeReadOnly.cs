using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200003E RID: 62
	public class TernaryTreeReadOnly : Object
	{
		// Token: 0x0600030D RID: 781 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
		// Note: this type is marked as 'beforefieldinit'.
		static TernaryTreeReadOnly()
		{
			Il2CppClassPointerStore<TernaryTreeReadOnly>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "TernaryTreeReadOnly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TernaryTreeReadOnly>.NativeClassPtr);
			TernaryTreeReadOnly.NativeFieldInfoPtr_nodeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TernaryTreeReadOnly>.NativeClassPtr, "nodeBuffer");
			TernaryTreeReadOnly.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TernaryTreeReadOnly>.NativeClassPtr, 100663672);
			TernaryTreeReadOnly.NativeMethodInfoPtr_FindCaseInsensitiveString_Public_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TernaryTreeReadOnly>.NativeClassPtr, 100663673);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0001FC1C File Offset: 0x0001DE1C
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TernaryTreeReadOnly(Il2CppStructArray<byte> nodeBuffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TernaryTreeReadOnly>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodeBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TernaryTreeReadOnly.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0001FC68 File Offset: 0x0001DE68
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 390194, RefRangeEnd = 390200, XrefRangeStart = 390190, XrefRangeEnd = 390194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte FindCaseInsensitiveString(string stringToFind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToFind);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TernaryTreeReadOnly.NativeMethodInfoPtr_FindCaseInsensitiveString_Public_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000032D7 File Offset: 0x000014D7
		public TernaryTreeReadOnly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0001FCB8 File Offset: 0x0001DEB8
		// (set) Token: 0x06000312 RID: 786 RVA: 0x000032E0 File Offset: 0x000014E0
		public unsafe Il2CppStructArray<byte> nodeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TernaryTreeReadOnly.NativeFieldInfoPtr_nodeBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TernaryTreeReadOnly.NativeFieldInfoPtr_nodeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_nodeBuffer;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_FindCaseInsensitiveString_Public_Byte_String_0;
	}
}
