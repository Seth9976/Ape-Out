using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200045D RID: 1117
	public class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060044AA RID: 17578 RVA: 0x0013C930 File Offset: 0x0013AB30
		// Note: this type is marked as 'beforefieldinit'.
		static SafeBuffer()
		{
			Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "SafeBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr);
			SafeBuffer.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, "inited");
			SafeBuffer.NativeMethodInfoPtr_AcquirePointer_Public_Void_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, 100673299);
			SafeBuffer.NativeMethodInfoPtr_ReleasePointer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, 100673300);
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x0013C99C File Offset: 0x0013AB9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 228066, RefRangeEnd = 228070, XrefRangeStart = 228065, XrefRangeEnd = 228066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcquirePointer(ref byte* pointer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(pointer);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SafeBuffer.NativeMethodInfoPtr_AcquirePointer_Public_Void_byref_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pointer = ((intPtr4 == 0) ? null : new byte*(intPtr4));
			}
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x0013C9F4 File Offset: 0x0013ABF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 228076, RefRangeEnd = 228080, XrefRangeStart = 228070, XrefRangeEnd = 228076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleasePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBuffer.NativeMethodInfoPtr_ReleasePointer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044AD RID: 17581 RVA: 0x0001A1D2 File Offset: 0x000183D2
		public SafeBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x060044AE RID: 17582 RVA: 0x0013CA28 File Offset: 0x0013AC28
		// (set) Token: 0x060044AF RID: 17583 RVA: 0x0001A1DB File Offset: 0x000183DB
		public unsafe bool inited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBuffer.NativeFieldInfoPtr_inited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBuffer.NativeFieldInfoPtr_inited)) = value;
			}
		}

		// Token: 0x04003805 RID: 14341
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04003806 RID: 14342
		private static readonly IntPtr NativeMethodInfoPtr_AcquirePointer_Public_Void_byref_ptr_Byte_0;

		// Token: 0x04003807 RID: 14343
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePointer_Public_Void_0;
	}
}
