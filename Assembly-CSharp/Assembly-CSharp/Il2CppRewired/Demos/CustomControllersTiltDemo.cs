using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired.Demos
{
	// Token: 0x0200020A RID: 522
	public class CustomControllersTiltDemo : MonoBehaviour
	{
		// Token: 0x06003FFD RID: 16381 RVA: 0x000EF914 File Offset: 0x000EDB14
		// Note: this type is marked as 'beforefieldinit'.
		static CustomControllersTiltDemo()
		{
			Il2CppClassPointerStore<CustomControllersTiltDemo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "CustomControllersTiltDemo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomControllersTiltDemo>.NativeClassPtr);
			CustomControllersTiltDemo.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllersTiltDemo>.NativeClassPtr, "target");
			CustomControllersTiltDemo.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllersTiltDemo>.NativeClassPtr, "speed");
			CustomControllersTiltDemo.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllersTiltDemo>.NativeClassPtr, "controller");
			CustomControllersTiltDemo.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllersTiltDemo>.NativeClassPtr, "player");
			CustomControllersTiltDemo.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllersTiltDemo>.NativeClassPtr, 100669546);
			CustomControllersTiltDemo.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllersTiltDemo>.NativeClassPtr, 100669547);
			CustomControllersTiltDemo.NativeMethodInfoPtr_OnInputUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllersTiltDemo>.NativeClassPtr, 100669548);
			CustomControllersTiltDemo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllersTiltDemo>.NativeClassPtr, 100669549);
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x000EF9E4 File Offset: 0x000EDBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103073, XrefRangeEnd = 103102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllersTiltDemo.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FFF RID: 16383 RVA: 0x000EFA18 File Offset: 0x000EDC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103102, XrefRangeEnd = 103126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllersTiltDemo.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x000EFA4C File Offset: 0x000EDC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103126, XrefRangeEnd = 103134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllersTiltDemo.NativeMethodInfoPtr_OnInputUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x000EFA80 File Offset: 0x000EDC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103134, XrefRangeEnd = 103137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllersTiltDemo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllersTiltDemo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllersTiltDemo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x000272C2 File Offset: 0x000254C2
		public CustomControllersTiltDemo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06004003 RID: 16387 RVA: 0x000EFABC File Offset: 0x000EDCBC
		// (set) Token: 0x06004004 RID: 16388 RVA: 0x000272CB File Offset: 0x000254CB
		public unsafe Transform target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllersTiltDemo.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllersTiltDemo.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06004005 RID: 16389 RVA: 0x000EFAEC File Offset: 0x000EDCEC
		// (set) Token: 0x06004006 RID: 16390 RVA: 0x000272EA File Offset: 0x000254EA
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllersTiltDemo.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllersTiltDemo.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06004007 RID: 16391 RVA: 0x000EFB14 File Offset: 0x000EDD14
		// (set) Token: 0x06004008 RID: 16392 RVA: 0x00027305 File Offset: 0x00025505
		public unsafe CustomController controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllersTiltDemo.NativeFieldInfoPtr_controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllersTiltDemo.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x06004009 RID: 16393 RVA: 0x000EFB44 File Offset: 0x000EDD44
		// (set) Token: 0x0600400A RID: 16394 RVA: 0x00027324 File Offset: 0x00025524
		public unsafe Player player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllersTiltDemo.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllersTiltDemo.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400274B RID: 10059
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x0400274C RID: 10060
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x0400274D RID: 10061
		private static readonly IntPtr NativeFieldInfoPtr_controller;

		// Token: 0x0400274E RID: 10062
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x0400274F RID: 10063
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002750 RID: 10064
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002751 RID: 10065
		private static readonly IntPtr NativeMethodInfoPtr_OnInputUpdate_Private_Void_0;

		// Token: 0x04002752 RID: 10066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
