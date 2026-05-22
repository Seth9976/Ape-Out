using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired.Demos
{
	// Token: 0x02000215 RID: 533
	public class PressAnyButtonToJoinExample_Assigner : MonoBehaviour
	{
		// Token: 0x0600410B RID: 16651 RVA: 0x000F2AC0 File Offset: 0x000F0CC0
		// Note: this type is marked as 'beforefieldinit'.
		static PressAnyButtonToJoinExample_Assigner()
		{
			Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "PressAnyButtonToJoinExample_Assigner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr);
			PressAnyButtonToJoinExample_Assigner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr, 100669643);
			PressAnyButtonToJoinExample_Assigner.NativeMethodInfoPtr_AssignJoysticksToPlayers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr, 100669644);
			PressAnyButtonToJoinExample_Assigner.NativeMethodInfoPtr_FindPlayerWithoutJoystick_Private_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr, 100669645);
			PressAnyButtonToJoinExample_Assigner.NativeMethodInfoPtr_DoAllPlayersHaveJoysticks_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr, 100669646);
			PressAnyButtonToJoinExample_Assigner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr, 100669647);
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x000F2B54 File Offset: 0x000F0D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104643, XrefRangeEnd = 104648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_Assigner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x000F2B88 File Offset: 0x000F0D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104680, RefRangeEnd = 104681, XrefRangeStart = 104648, XrefRangeEnd = 104680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignJoysticksToPlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_Assigner.NativeMethodInfoPtr_AssignJoysticksToPlayers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x000F2BBC File Offset: 0x000F0DBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 104694, RefRangeEnd = 104697, XrefRangeStart = 104681, XrefRangeEnd = 104694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player FindPlayerWithoutJoystick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_Assigner.NativeMethodInfoPtr_FindPlayerWithoutJoystick_Private_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x000F2BFC File Offset: 0x000F0DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104697, XrefRangeEnd = 104698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoAllPlayersHaveJoysticks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_Assigner.NativeMethodInfoPtr_DoAllPlayersHaveJoysticks_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x000F2C38 File Offset: 0x000F0E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PressAnyButtonToJoinExample_Assigner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressAnyButtonToJoinExample_Assigner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_Assigner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x00027B93 File Offset: 0x00025D93
		public PressAnyButtonToJoinExample_Assigner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040027F6 RID: 10230
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040027F7 RID: 10231
		private static readonly IntPtr NativeMethodInfoPtr_AssignJoysticksToPlayers_Private_Void_0;

		// Token: 0x040027F8 RID: 10232
		private static readonly IntPtr NativeMethodInfoPtr_FindPlayerWithoutJoystick_Private_Player_0;

		// Token: 0x040027F9 RID: 10233
		private static readonly IntPtr NativeMethodInfoPtr_DoAllPlayersHaveJoysticks_Private_Boolean_0;

		// Token: 0x040027FA RID: 10234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
