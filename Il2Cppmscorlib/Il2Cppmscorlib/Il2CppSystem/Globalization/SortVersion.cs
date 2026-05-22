using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000244 RID: 580
	[Serializable]
	public sealed class SortVersion : Object
	{
		// Token: 0x06002792 RID: 10130 RVA: 0x000D35A8 File Offset: 0x000D17A8
		// Note: this type is marked as 'beforefieldinit'.
		static SortVersion()
		{
			Il2CppClassPointerStore<SortVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "SortVersion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortVersion>.NativeClassPtr);
			SortVersion.NativeFieldInfoPtr_m_NlsVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortVersion>.NativeClassPtr, "m_NlsVersion");
			SortVersion.NativeFieldInfoPtr_m_SortId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortVersion>.NativeClassPtr, "m_SortId");
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x0000D7AA File Offset: 0x0000B9AA
		public SortVersion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x000D3600 File Offset: 0x000D1800
		// (set) Token: 0x06002795 RID: 10133 RVA: 0x0000D7B3 File Offset: 0x0000B9B3
		public unsafe int m_NlsVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortVersion.NativeFieldInfoPtr_m_NlsVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortVersion.NativeFieldInfoPtr_m_NlsVersion)) = value;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x000D3628 File Offset: 0x000D1828
		// (set) Token: 0x06002797 RID: 10135 RVA: 0x0000D7CE File Offset: 0x0000B9CE
		public unsafe Guid m_SortId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortVersion.NativeFieldInfoPtr_m_SortId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortVersion.NativeFieldInfoPtr_m_SortId)) = value;
			}
		}

		// Token: 0x04002340 RID: 9024
		private static readonly IntPtr NativeFieldInfoPtr_m_NlsVersion;

		// Token: 0x04002341 RID: 9025
		private static readonly IntPtr NativeFieldInfoPtr_m_SortId;
	}
}
