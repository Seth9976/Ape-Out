using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.LowLevel
{
	// Token: 0x02000142 RID: 322
	public sealed class PlayerLoopSystemInternal : ValueType
	{
		// Token: 0x0600195D RID: 6493 RVA: 0x000619EC File Offset: 0x0005FBEC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerLoopSystemInternal()
		{
			Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.LowLevel", "PlayerLoopSystemInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr);
			PlayerLoopSystemInternal.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "type");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "updateDelegate");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "updateFunction");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "loopConditionFunction");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "numSubSystems");
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x0000D3CE File Offset: 0x0000B5CE
		public PlayerLoopSystemInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x0000D3D7 File Offset: 0x0000B5D7
		public PlayerLoopSystemInternal()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr))
		{
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x00061A80 File Offset: 0x0005FC80
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x0000D3E9 File Offset: 0x0000B5E9
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00061AB0 File Offset: 0x0005FCB0
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x0000D408 File Offset: 0x0000B608
		public unsafe PlayerLoopSystem.UpdateFunction updateDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerLoopSystem.UpdateFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00061AE0 File Offset: 0x0005FCE0
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x0000D427 File Offset: 0x0000B627
		public unsafe IntPtr updateFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction)) = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00061B08 File Offset: 0x0005FD08
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x0000D442 File Offset: 0x0000B642
		public unsafe IntPtr loopConditionFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction)) = value;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00061B30 File Offset: 0x0005FD30
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x0000D45D File Offset: 0x0000B65D
		public unsafe int numSubSystems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems)) = value;
			}
		}

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeFieldInfoPtr_updateDelegate;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeFieldInfoPtr_updateFunction;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeFieldInfoPtr_loopConditionFunction;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeFieldInfoPtr_numSubSystems;
	}
}
