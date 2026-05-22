using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2Cpp
{
	// Token: 0x020001A9 RID: 425
	public class State : MessageReceiver
	{
		// Token: 0x06003098 RID: 12440 RVA: 0x000BA094 File Offset: 0x000B8294
		// Note: this type is marked as 'beforefieldinit'.
		static State()
		{
			Il2CppClassPointerStore<State>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "State");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<State>.NativeClassPtr);
			State.NativeFieldInfoPtr_maxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "maxHealth");
			State.NativeFieldInfoPtr_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "health");
			State.NativeFieldInfoPtr_dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "dead");
			State.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667095);
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x000BA114 File Offset: 0x000B8314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84553, RefRangeEnd = 84555, XrefRangeStart = 84547, XrefRangeEnd = 84553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe State()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<State>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x000216A9 File Offset: 0x0001F8A9
		public State(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x000BA150 File Offset: 0x000B8350
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x000216B2 File Offset: 0x0001F8B2
		public unsafe int maxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_maxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_maxHealth)) = value;
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x000BA178 File Offset: 0x000B8378
		// (set) Token: 0x0600309E RID: 12446 RVA: 0x000216CD File Offset: 0x0001F8CD
		public unsafe int health
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_health);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_health)) = value;
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x000BA1A0 File Offset: 0x000B83A0
		// (set) Token: 0x060030A0 RID: 12448 RVA: 0x000216E8 File Offset: 0x0001F8E8
		public unsafe bool dead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_dead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_dead)) = value;
			}
		}

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeFieldInfoPtr_maxHealth;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeFieldInfoPtr_health;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeFieldInfoPtr_dead;

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
