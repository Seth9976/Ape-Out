using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x0200010D RID: 269
	public sealed class CustomClassObfuscation : Attribute
	{
		// Token: 0x06001A22 RID: 6690 RVA: 0x00092D20 File Offset: 0x00090F20
		// Note: this type is marked as 'beforefieldinit'.
		static CustomClassObfuscation()
		{
			Il2CppClassPointerStore<CustomClassObfuscation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "CustomClassObfuscation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomClassObfuscation>.NativeClassPtr);
			CustomClassObfuscation.NativeFieldInfoPtr_renamePubIntMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomClassObfuscation>.NativeClassPtr, "renamePubIntMembers");
			CustomClassObfuscation.NativeFieldInfoPtr_renamePrivateMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomClassObfuscation>.NativeClassPtr, "renamePrivateMembers");
			CustomClassObfuscation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomClassObfuscation>.NativeClassPtr, 100669485);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00092D8C File Offset: 0x00090F8C
		[CallerCount(0)]
		public unsafe CustomClassObfuscation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomClassObfuscation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomClassObfuscation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0000AADD File Offset: 0x00008CDD
		public CustomClassObfuscation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x00092DC8 File Offset: 0x00090FC8
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x0000AAE6 File Offset: 0x00008CE6
		public unsafe bool renamePubIntMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomClassObfuscation.NativeFieldInfoPtr_renamePubIntMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomClassObfuscation.NativeFieldInfoPtr_renamePubIntMembers)) = value;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x00092DF0 File Offset: 0x00090FF0
		// (set) Token: 0x06001A28 RID: 6696 RVA: 0x0000AB01 File Offset: 0x00008D01
		public unsafe bool renamePrivateMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomClassObfuscation.NativeFieldInfoPtr_renamePrivateMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomClassObfuscation.NativeFieldInfoPtr_renamePrivateMembers)) = value;
			}
		}

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeFieldInfoPtr_renamePubIntMembers;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeFieldInfoPtr_renamePrivateMembers;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
