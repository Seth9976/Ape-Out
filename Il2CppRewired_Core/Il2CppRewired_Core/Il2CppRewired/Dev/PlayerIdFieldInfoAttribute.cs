using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Dev
{
	// Token: 0x0200000A RID: 10
	public class PlayerIdFieldInfoAttribute : Attribute
	{
		// Token: 0x0600003A RID: 58 RVA: 0x0002D074 File Offset: 0x0002B274
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerIdFieldInfoAttribute()
		{
			Il2CppClassPointerStore<PlayerIdFieldInfoAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Dev", "PlayerIdFieldInfoAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerIdFieldInfoAttribute>.NativeClassPtr);
			PlayerIdFieldInfoAttribute.NativeFieldInfoPtr_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerIdFieldInfoAttribute>.NativeClassPtr, "friendlyName");
			PlayerIdFieldInfoAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerIdFieldInfoAttribute>.NativeClassPtr, 100663312);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0002D0CC File Offset: 0x0002B2CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerIdFieldInfoAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerIdFieldInfoAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerIdFieldInfoAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002248 File Offset: 0x00000448
		public PlayerIdFieldInfoAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0002D108 File Offset: 0x0002B308
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002251 File Offset: 0x00000451
		public unsafe string friendlyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerIdFieldInfoAttribute.NativeFieldInfoPtr_friendlyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerIdFieldInfoAttribute.NativeFieldInfoPtr_friendlyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_friendlyName;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
