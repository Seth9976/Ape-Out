using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000454 RID: 1108
	[Serializable]
	public sealed class ErrorWrapper : Object
	{
		// Token: 0x0600440C RID: 17420 RVA: 0x00019F6B File Offset: 0x0001816B
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorWrapper()
		{
			Il2CppClassPointerStore<ErrorWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ErrorWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorWrapper>.NativeClassPtr);
			ErrorWrapper.NativeFieldInfoPtr_m_ErrorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorWrapper>.NativeClassPtr, "m_ErrorCode");
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x00019FA4 File Offset: 0x000181A4
		public ErrorWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x0600440E RID: 17422 RVA: 0x00139E90 File Offset: 0x00138090
		// (set) Token: 0x0600440F RID: 17423 RVA: 0x00019FAD File Offset: 0x000181AD
		public unsafe int m_ErrorCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorWrapper.NativeFieldInfoPtr_m_ErrorCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorWrapper.NativeFieldInfoPtr_m_ErrorCode)) = value;
			}
		}

		// Token: 0x04003783 RID: 14211
		private static readonly IntPtr NativeFieldInfoPtr_m_ErrorCode;
	}
}
