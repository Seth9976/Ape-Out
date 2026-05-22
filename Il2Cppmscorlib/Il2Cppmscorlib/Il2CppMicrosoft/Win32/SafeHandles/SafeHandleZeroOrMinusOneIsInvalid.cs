using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x0200004E RID: 78
	public class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x00035B50 File Offset: 0x00033D50
		// Note: this type is marked as 'beforefieldinit'.
		static SafeHandleZeroOrMinusOneIsInvalid()
		{
			Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeHandleZeroOrMinusOneIsInvalid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr);
			SafeHandleZeroOrMinusOneIsInvalid.NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr, 100664006);
			SafeHandleZeroOrMinusOneIsInvalid.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr, 100664007);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00035BA8 File Offset: 0x00033DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138563, XrefRangeEnd = 138565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ownsHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandleZeroOrMinusOneIsInvalid.NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00035BF0 File Offset: 0x00033DF0
		public unsafe override bool IsInvalid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandleZeroOrMinusOneIsInvalid.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00003DF9 File Offset: 0x00001FF9
		public SafeHandleZeroOrMinusOneIsInvalid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0;
	}
}
