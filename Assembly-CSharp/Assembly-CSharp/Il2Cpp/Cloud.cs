using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000A8 RID: 168
	public class Cloud : MonoBehaviour
	{
		// Token: 0x06001441 RID: 5185 RVA: 0x0006DD1C File Offset: 0x0006BF1C
		// Note: this type is marked as 'beforefieldinit'.
		static Cloud()
		{
			Il2CppClassPointerStore<Cloud>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Cloud");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cloud>.NativeClassPtr);
			Cloud.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cloud>.NativeClassPtr, "cam");
			Cloud.NativeFieldInfoPtr_pt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cloud>.NativeClassPtr, "pt");
			Cloud.NativeFieldInfoPtr_superCloud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cloud>.NativeClassPtr, "superCloud");
			Cloud.NativeFieldInfoPtr_stopLooping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cloud>.NativeClassPtr, "stopLooping");
			Cloud.NativeFieldInfoPtr_goingDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cloud>.NativeClassPtr, "goingDown");
			Cloud.NativeFieldInfoPtr_spd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cloud>.NativeClassPtr, "spd");
			Cloud.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cloud>.NativeClassPtr, 100665019);
			Cloud.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cloud>.NativeClassPtr, 100665020);
			Cloud.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cloud>.NativeClassPtr, 100665021);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0006DE00 File Offset: 0x0006C000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52235, XrefRangeEnd = 52237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cloud.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0006DE34 File Offset: 0x0006C034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52237, XrefRangeEnd = 52294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cloud.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0006DE68 File Offset: 0x0006C068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cloud()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cloud>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cloud.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0000EC3C File Offset: 0x0000CE3C
		public Cloud(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0006DEA4 File Offset: 0x0006C0A4
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x0000EC45 File Offset: 0x0000CE45
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cloud.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cloud.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0006DED4 File Offset: 0x0006C0D4
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x0000EC64 File Offset: 0x0000CE64
		public unsafe Vector2 pt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cloud.NativeFieldInfoPtr_pt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cloud.NativeFieldInfoPtr_pt)) = value;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x0006DEFC File Offset: 0x0006C0FC
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x0000EC7F File Offset: 0x0000CE7F
		public unsafe bool superCloud
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cloud.NativeFieldInfoPtr_superCloud);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cloud.NativeFieldInfoPtr_superCloud)) = value;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0006DF24 File Offset: 0x0006C124
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x0000EC9A File Offset: 0x0000CE9A
		public unsafe bool stopLooping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cloud.NativeFieldInfoPtr_stopLooping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cloud.NativeFieldInfoPtr_stopLooping)) = value;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0006DF4C File Offset: 0x0006C14C
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x0000ECB5 File Offset: 0x0000CEB5
		public unsafe bool goingDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cloud.NativeFieldInfoPtr_goingDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cloud.NativeFieldInfoPtr_goingDown)) = value;
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0006DF74 File Offset: 0x0006C174
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		public unsafe float spd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cloud.NativeFieldInfoPtr_spd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cloud.NativeFieldInfoPtr_spd)) = value;
			}
		}

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeFieldInfoPtr_pt;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeFieldInfoPtr_superCloud;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeFieldInfoPtr_stopLooping;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeFieldInfoPtr_goingDown;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeFieldInfoPtr_spd;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
