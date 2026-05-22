using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSanford.Multimedia
{
	// Token: 0x02000182 RID: 386
	public class ErrorEventArgs : EventArgs
	{
		// Token: 0x0600116A RID: 4458 RVA: 0x00053E50 File Offset: 0x00052050
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorEventArgs()
		{
			Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia", "ErrorEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr);
			ErrorEventArgs.NativeFieldInfoPtr_ex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr, "ex");
			ErrorEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr, 100665806);
			ErrorEventArgs.NativeMethodInfoPtr_get_Error_Public_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr, 100665807);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00053EBC File Offset: 0x000520BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 14110, RefRangeEnd = 14114, XrefRangeStart = 14107, XrefRangeEnd = 14110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorEventArgs(Exception ex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorEventArgs.NativeMethodInfoPtr__ctor_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x00053F08 File Offset: 0x00052108
		public unsafe Exception Error
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorEventArgs.NativeMethodInfoPtr_get_Error_Public_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0000729E File Offset: 0x0000549E
		public ErrorEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x00053F48 File Offset: 0x00052148
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x000072A7 File Offset: 0x000054A7
		public unsafe Exception ex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorEventArgs.NativeFieldInfoPtr_ex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorEventArgs.NativeFieldInfoPtr_ex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeFieldInfoPtr_ex;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_0;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_Exception_0;
	}
}
