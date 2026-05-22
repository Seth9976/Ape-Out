using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000097 RID: 151
	public sealed class CustomRenderTexture : RenderTexture
	{
		// Token: 0x06000DE5 RID: 3557 RVA: 0x00039CC4 File Offset: 0x00037EC4
		// Note: this type is marked as 'beforefieldinit'.
		static CustomRenderTexture()
		{
			Il2CppClassPointerStore<CustomRenderTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CustomRenderTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomRenderTexture>.NativeClassPtr);
			CustomRenderTexture.Internal_CreateCustomRenderTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.Internal_CreateCustomRenderTextureDelegate>("UnityEngine.CustomRenderTexture::Internal_CreateCustomRenderTexture");
			CustomRenderTexture.TriggerUpdateDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.TriggerUpdateDelegate>("UnityEngine.CustomRenderTexture::TriggerUpdate");
			CustomRenderTexture.TriggerInitializationDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.TriggerInitializationDelegate>("UnityEngine.CustomRenderTexture::TriggerInitialization");
			CustomRenderTexture.ClearUpdateZonesDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.ClearUpdateZonesDelegate>("UnityEngine.CustomRenderTexture::ClearUpdateZones");
			CustomRenderTexture.get_materialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_materialDelegate>("UnityEngine.CustomRenderTexture::get_material");
			CustomRenderTexture.set_materialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_materialDelegate>("UnityEngine.CustomRenderTexture::set_material");
			CustomRenderTexture.get_initializationMaterialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationMaterialDelegate>("UnityEngine.CustomRenderTexture::get_initializationMaterial");
			CustomRenderTexture.set_initializationMaterialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationMaterialDelegate>("UnityEngine.CustomRenderTexture::set_initializationMaterial");
			CustomRenderTexture.get_initializationTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationTextureDelegate>("UnityEngine.CustomRenderTexture::get_initializationTexture");
			CustomRenderTexture.set_initializationTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationTextureDelegate>("UnityEngine.CustomRenderTexture::set_initializationTexture");
			CustomRenderTexture.GetUpdateZonesInternalDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.GetUpdateZonesInternalDelegate>("UnityEngine.CustomRenderTexture::GetUpdateZonesInternal");
			CustomRenderTexture.GetDoubleBufferRenderTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.GetDoubleBufferRenderTextureDelegate>("UnityEngine.CustomRenderTexture::GetDoubleBufferRenderTexture");
			CustomRenderTexture.EnsureDoubleBufferConsistencyDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.EnsureDoubleBufferConsistencyDelegate>("UnityEngine.CustomRenderTexture::EnsureDoubleBufferConsistency");
			CustomRenderTexture.get_initializationSourceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationSourceDelegate>("UnityEngine.CustomRenderTexture::get_initializationSource");
			CustomRenderTexture.set_initializationSourceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationSourceDelegate>("UnityEngine.CustomRenderTexture::set_initializationSource");
			CustomRenderTexture.get_updateModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updateModeDelegate>("UnityEngine.CustomRenderTexture::get_updateMode");
			CustomRenderTexture.set_updateModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updateModeDelegate>("UnityEngine.CustomRenderTexture::set_updateMode");
			CustomRenderTexture.get_initializationModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationModeDelegate>("UnityEngine.CustomRenderTexture::get_initializationMode");
			CustomRenderTexture.set_initializationModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationModeDelegate>("UnityEngine.CustomRenderTexture::set_initializationMode");
			CustomRenderTexture.get_updateZoneSpaceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updateZoneSpaceDelegate>("UnityEngine.CustomRenderTexture::get_updateZoneSpace");
			CustomRenderTexture.set_updateZoneSpaceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updateZoneSpaceDelegate>("UnityEngine.CustomRenderTexture::set_updateZoneSpace");
			CustomRenderTexture.get_shaderPassDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_shaderPassDelegate>("UnityEngine.CustomRenderTexture::get_shaderPass");
			CustomRenderTexture.set_shaderPassDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_shaderPassDelegate>("UnityEngine.CustomRenderTexture::set_shaderPass");
			CustomRenderTexture.get_cubemapFaceMaskDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_cubemapFaceMaskDelegate>("UnityEngine.CustomRenderTexture::get_cubemapFaceMask");
			CustomRenderTexture.set_cubemapFaceMaskDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_cubemapFaceMaskDelegate>("UnityEngine.CustomRenderTexture::set_cubemapFaceMask");
			CustomRenderTexture.get_doubleBufferedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_doubleBufferedDelegate>("UnityEngine.CustomRenderTexture::get_doubleBuffered");
			CustomRenderTexture.set_doubleBufferedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_doubleBufferedDelegate>("UnityEngine.CustomRenderTexture::set_doubleBuffered");
			CustomRenderTexture.get_wrapUpdateZonesDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_wrapUpdateZonesDelegate>("UnityEngine.CustomRenderTexture::get_wrapUpdateZones");
			CustomRenderTexture.set_wrapUpdateZonesDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_wrapUpdateZonesDelegate>("UnityEngine.CustomRenderTexture::set_wrapUpdateZones");
			CustomRenderTexture.get_updatePeriodDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updatePeriodDelegate>("UnityEngine.CustomRenderTexture::get_updatePeriod");
			CustomRenderTexture.set_updatePeriodDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updatePeriodDelegate>("UnityEngine.CustomRenderTexture::set_updatePeriod");
			CustomRenderTexture.get_initializationColor_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationColor_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationColor_Injected");
			CustomRenderTexture.set_initializationColor_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationColor_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationColor_Injected");
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00009662 File Offset: 0x00007862
		public CustomRenderTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0000966B File Offset: 0x0000786B
		public static void Internal_CreateCustomRenderTexture(CustomRenderTexture rt)
		{
			CustomRenderTexture.Internal_CreateCustomRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rt));
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0000967D File Offset: 0x0000787D
		public void TriggerUpdate(int count)
		{
			CustomRenderTexture.TriggerUpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), count);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00009690 File Offset: 0x00007890
		public void Update(int count)
		{
			CustomRenderTextureManager.InvokeTriggerUpdate(this, count);
			this.TriggerUpdate(count);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x000096A3 File Offset: 0x000078A3
		public void Update()
		{
			this.Update(1);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000096AE File Offset: 0x000078AE
		public void TriggerInitialization()
		{
			CustomRenderTexture.TriggerInitializationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000096C0 File Offset: 0x000078C0
		public void Initialize()
		{
			this.TriggerInitialization();
			CustomRenderTextureManager.InvokeTriggerInitialize(this);
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x000096D1 File Offset: 0x000078D1
		public void ClearUpdateZones()
		{
			CustomRenderTexture.ClearUpdateZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x00039EE4 File Offset: 0x000380E4
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x000096E3 File Offset: 0x000078E3
		public Material material
		{
			get
			{
				IntPtr intPtr = CustomRenderTexture.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				CustomRenderTexture.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00039F10 File Offset: 0x00038110
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x000096FB File Offset: 0x000078FB
		public Material initializationMaterial
		{
			get
			{
				IntPtr intPtr = CustomRenderTexture.get_initializationMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				CustomRenderTexture.set_initializationMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00039F3C File Offset: 0x0003813C
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x00009713 File Offset: 0x00007913
		public Texture initializationTexture
		{
			get
			{
				IntPtr intPtr = CustomRenderTexture.get_initializationTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				CustomRenderTexture.set_initializationTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0000972B File Offset: 0x0000792B
		public void GetUpdateZonesInternal(Object updateZones)
		{
			CustomRenderTexture.GetUpdateZonesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(updateZones));
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00039F68 File Offset: 0x00038168
		public RenderTexture GetDoubleBufferRenderTexture()
		{
			IntPtr intPtr = CustomRenderTexture.GetDoubleBufferRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00009743 File Offset: 0x00007943
		public void EnsureDoubleBufferConsistency()
		{
			CustomRenderTexture.EnsureDoubleBufferConsistencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00009755 File Offset: 0x00007955
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x00009767 File Offset: 0x00007967
		public CustomRenderTextureInitializationSource initializationSource
		{
			get
			{
				return CustomRenderTexture.get_initializationSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_initializationSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00039F94 File Offset: 0x00038194
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x0000977A File Offset: 0x0000797A
		public Color initializationColor
		{
			get
			{
				Color color;
				this.get_initializationColor_Injected(out color);
				return color;
			}
			set
			{
				this.set_initializationColor_Injected(ref value);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x00009784 File Offset: 0x00007984
		// (set) Token: 0x06000DFC RID: 3580 RVA: 0x00009796 File Offset: 0x00007996
		public CustomRenderTextureUpdateMode updateMode
		{
			get
			{
				return CustomRenderTexture.get_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x000097A9 File Offset: 0x000079A9
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x000097BB File Offset: 0x000079BB
		public CustomRenderTextureUpdateMode initializationMode
		{
			get
			{
				return CustomRenderTexture.get_initializationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_initializationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x000097CE File Offset: 0x000079CE
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x000097E0 File Offset: 0x000079E0
		public CustomRenderTextureUpdateZoneSpace updateZoneSpace
		{
			get
			{
				return CustomRenderTexture.get_updateZoneSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_updateZoneSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x000097F3 File Offset: 0x000079F3
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x00009805 File Offset: 0x00007A05
		public int shaderPass
		{
			get
			{
				return CustomRenderTexture.get_shaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_shaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00009818 File Offset: 0x00007A18
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x0000982A File Offset: 0x00007A2A
		public uint cubemapFaceMask
		{
			get
			{
				return CustomRenderTexture.get_cubemapFaceMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_cubemapFaceMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x0000983D File Offset: 0x00007A3D
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x0000984F File Offset: 0x00007A4F
		public bool doubleBuffered
		{
			get
			{
				return CustomRenderTexture.get_doubleBufferedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_doubleBufferedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00009862 File Offset: 0x00007A62
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x00009874 File Offset: 0x00007A74
		public bool wrapUpdateZones
		{
			get
			{
				return CustomRenderTexture.get_wrapUpdateZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_wrapUpdateZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00009887 File Offset: 0x00007A87
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x00009899 File Offset: 0x00007A99
		public float updatePeriod
		{
			get
			{
				return CustomRenderTexture.get_updatePeriodDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_updatePeriodDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x000098AC File Offset: 0x00007AAC
		public void get_initializationColor_Injected(out Color ret)
		{
			CustomRenderTexture.get_initializationColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x000098BF File Offset: 0x00007ABF
		public void set_initializationColor_Injected(ref Color value)
		{
			CustomRenderTexture.set_initializationColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000A35 RID: 2613
		private static readonly CustomRenderTexture.Internal_CreateCustomRenderTextureDelegate Internal_CreateCustomRenderTextureDelegateField;

		// Token: 0x04000A36 RID: 2614
		private static readonly CustomRenderTexture.TriggerUpdateDelegate TriggerUpdateDelegateField;

		// Token: 0x04000A37 RID: 2615
		private static readonly CustomRenderTexture.TriggerInitializationDelegate TriggerInitializationDelegateField;

		// Token: 0x04000A38 RID: 2616
		private static readonly CustomRenderTexture.ClearUpdateZonesDelegate ClearUpdateZonesDelegateField;

		// Token: 0x04000A39 RID: 2617
		private static readonly CustomRenderTexture.get_materialDelegate get_materialDelegateField;

		// Token: 0x04000A3A RID: 2618
		private static readonly CustomRenderTexture.set_materialDelegate set_materialDelegateField;

		// Token: 0x04000A3B RID: 2619
		private static readonly CustomRenderTexture.get_initializationMaterialDelegate get_initializationMaterialDelegateField;

		// Token: 0x04000A3C RID: 2620
		private static readonly CustomRenderTexture.set_initializationMaterialDelegate set_initializationMaterialDelegateField;

		// Token: 0x04000A3D RID: 2621
		private static readonly CustomRenderTexture.get_initializationTextureDelegate get_initializationTextureDelegateField;

		// Token: 0x04000A3E RID: 2622
		private static readonly CustomRenderTexture.set_initializationTextureDelegate set_initializationTextureDelegateField;

		// Token: 0x04000A3F RID: 2623
		private static readonly CustomRenderTexture.GetUpdateZonesInternalDelegate GetUpdateZonesInternalDelegateField;

		// Token: 0x04000A40 RID: 2624
		private static readonly CustomRenderTexture.GetDoubleBufferRenderTextureDelegate GetDoubleBufferRenderTextureDelegateField;

		// Token: 0x04000A41 RID: 2625
		private static readonly CustomRenderTexture.EnsureDoubleBufferConsistencyDelegate EnsureDoubleBufferConsistencyDelegateField;

		// Token: 0x04000A42 RID: 2626
		private static readonly CustomRenderTexture.get_initializationSourceDelegate get_initializationSourceDelegateField;

		// Token: 0x04000A43 RID: 2627
		private static readonly CustomRenderTexture.set_initializationSourceDelegate set_initializationSourceDelegateField;

		// Token: 0x04000A44 RID: 2628
		private static readonly CustomRenderTexture.get_updateModeDelegate get_updateModeDelegateField;

		// Token: 0x04000A45 RID: 2629
		private static readonly CustomRenderTexture.set_updateModeDelegate set_updateModeDelegateField;

		// Token: 0x04000A46 RID: 2630
		private static readonly CustomRenderTexture.get_initializationModeDelegate get_initializationModeDelegateField;

		// Token: 0x04000A47 RID: 2631
		private static readonly CustomRenderTexture.set_initializationModeDelegate set_initializationModeDelegateField;

		// Token: 0x04000A48 RID: 2632
		private static readonly CustomRenderTexture.get_updateZoneSpaceDelegate get_updateZoneSpaceDelegateField;

		// Token: 0x04000A49 RID: 2633
		private static readonly CustomRenderTexture.set_updateZoneSpaceDelegate set_updateZoneSpaceDelegateField;

		// Token: 0x04000A4A RID: 2634
		private static readonly CustomRenderTexture.get_shaderPassDelegate get_shaderPassDelegateField;

		// Token: 0x04000A4B RID: 2635
		private static readonly CustomRenderTexture.set_shaderPassDelegate set_shaderPassDelegateField;

		// Token: 0x04000A4C RID: 2636
		private static readonly CustomRenderTexture.get_cubemapFaceMaskDelegate get_cubemapFaceMaskDelegateField;

		// Token: 0x04000A4D RID: 2637
		private static readonly CustomRenderTexture.set_cubemapFaceMaskDelegate set_cubemapFaceMaskDelegateField;

		// Token: 0x04000A4E RID: 2638
		private static readonly CustomRenderTexture.get_doubleBufferedDelegate get_doubleBufferedDelegateField;

		// Token: 0x04000A4F RID: 2639
		private static readonly CustomRenderTexture.set_doubleBufferedDelegate set_doubleBufferedDelegateField;

		// Token: 0x04000A50 RID: 2640
		private static readonly CustomRenderTexture.get_wrapUpdateZonesDelegate get_wrapUpdateZonesDelegateField;

		// Token: 0x04000A51 RID: 2641
		private static readonly CustomRenderTexture.set_wrapUpdateZonesDelegate set_wrapUpdateZonesDelegateField;

		// Token: 0x04000A52 RID: 2642
		private static readonly CustomRenderTexture.get_updatePeriodDelegate get_updatePeriodDelegateField;

		// Token: 0x04000A53 RID: 2643
		private static readonly CustomRenderTexture.set_updatePeriodDelegate set_updatePeriodDelegateField;

		// Token: 0x04000A54 RID: 2644
		private static readonly CustomRenderTexture.get_initializationColor_InjectedDelegate get_initializationColor_InjectedDelegateField;

		// Token: 0x04000A55 RID: 2645
		private static readonly CustomRenderTexture.set_initializationColor_InjectedDelegate set_initializationColor_InjectedDelegateField;

		// Token: 0x0200073B RID: 1851
		// (Invoke) Token: 0x06002C93 RID: 11411
		private delegate void Internal_CreateCustomRenderTextureDelegate(IntPtr rt);

		// Token: 0x0200073C RID: 1852
		// (Invoke) Token: 0x06002C95 RID: 11413
		private delegate void TriggerUpdateDelegate(IntPtr @this, int count);

		// Token: 0x0200073D RID: 1853
		// (Invoke) Token: 0x06002C97 RID: 11415
		private delegate void TriggerInitializationDelegate(IntPtr @this);

		// Token: 0x0200073E RID: 1854
		// (Invoke) Token: 0x06002C99 RID: 11417
		private delegate void ClearUpdateZonesDelegate(IntPtr @this);

		// Token: 0x0200073F RID: 1855
		// (Invoke) Token: 0x06002C9B RID: 11419
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x02000740 RID: 1856
		// (Invoke) Token: 0x06002C9D RID: 11421
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000741 RID: 1857
		// (Invoke) Token: 0x06002C9F RID: 11423
		private delegate IntPtr get_initializationMaterialDelegate(IntPtr @this);

		// Token: 0x02000742 RID: 1858
		// (Invoke) Token: 0x06002CA1 RID: 11425
		private delegate void set_initializationMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000743 RID: 1859
		// (Invoke) Token: 0x06002CA3 RID: 11427
		private delegate IntPtr get_initializationTextureDelegate(IntPtr @this);

		// Token: 0x02000744 RID: 1860
		// (Invoke) Token: 0x06002CA5 RID: 11429
		private delegate void set_initializationTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000745 RID: 1861
		// (Invoke) Token: 0x06002CA7 RID: 11431
		private delegate void GetUpdateZonesInternalDelegate(IntPtr @this, IntPtr updateZones);

		// Token: 0x02000746 RID: 1862
		// (Invoke) Token: 0x06002CA9 RID: 11433
		private delegate IntPtr GetDoubleBufferRenderTextureDelegate(IntPtr @this);

		// Token: 0x02000747 RID: 1863
		// (Invoke) Token: 0x06002CAB RID: 11435
		private delegate void EnsureDoubleBufferConsistencyDelegate(IntPtr @this);

		// Token: 0x02000748 RID: 1864
		// (Invoke) Token: 0x06002CAD RID: 11437
		private delegate CustomRenderTextureInitializationSource get_initializationSourceDelegate(IntPtr @this);

		// Token: 0x02000749 RID: 1865
		// (Invoke) Token: 0x06002CAF RID: 11439
		private delegate void set_initializationSourceDelegate(IntPtr @this, CustomRenderTextureInitializationSource value);

		// Token: 0x0200074A RID: 1866
		// (Invoke) Token: 0x06002CB1 RID: 11441
		private delegate CustomRenderTextureUpdateMode get_updateModeDelegate(IntPtr @this);

		// Token: 0x0200074B RID: 1867
		// (Invoke) Token: 0x06002CB3 RID: 11443
		private delegate void set_updateModeDelegate(IntPtr @this, CustomRenderTextureUpdateMode value);

		// Token: 0x0200074C RID: 1868
		// (Invoke) Token: 0x06002CB5 RID: 11445
		private delegate CustomRenderTextureUpdateMode get_initializationModeDelegate(IntPtr @this);

		// Token: 0x0200074D RID: 1869
		// (Invoke) Token: 0x06002CB7 RID: 11447
		private delegate void set_initializationModeDelegate(IntPtr @this, CustomRenderTextureUpdateMode value);

		// Token: 0x0200074E RID: 1870
		// (Invoke) Token: 0x06002CB9 RID: 11449
		private delegate CustomRenderTextureUpdateZoneSpace get_updateZoneSpaceDelegate(IntPtr @this);

		// Token: 0x0200074F RID: 1871
		// (Invoke) Token: 0x06002CBB RID: 11451
		private delegate void set_updateZoneSpaceDelegate(IntPtr @this, CustomRenderTextureUpdateZoneSpace value);

		// Token: 0x02000750 RID: 1872
		// (Invoke) Token: 0x06002CBD RID: 11453
		private delegate int get_shaderPassDelegate(IntPtr @this);

		// Token: 0x02000751 RID: 1873
		// (Invoke) Token: 0x06002CBF RID: 11455
		private delegate void set_shaderPassDelegate(IntPtr @this, int value);

		// Token: 0x02000752 RID: 1874
		// (Invoke) Token: 0x06002CC1 RID: 11457
		private delegate uint get_cubemapFaceMaskDelegate(IntPtr @this);

		// Token: 0x02000753 RID: 1875
		// (Invoke) Token: 0x06002CC3 RID: 11459
		private delegate void set_cubemapFaceMaskDelegate(IntPtr @this, uint value);

		// Token: 0x02000754 RID: 1876
		// (Invoke) Token: 0x06002CC5 RID: 11461
		private delegate bool get_doubleBufferedDelegate(IntPtr @this);

		// Token: 0x02000755 RID: 1877
		// (Invoke) Token: 0x06002CC7 RID: 11463
		private delegate void set_doubleBufferedDelegate(IntPtr @this, bool value);

		// Token: 0x02000756 RID: 1878
		// (Invoke) Token: 0x06002CC9 RID: 11465
		private delegate bool get_wrapUpdateZonesDelegate(IntPtr @this);

		// Token: 0x02000757 RID: 1879
		// (Invoke) Token: 0x06002CCB RID: 11467
		private delegate void set_wrapUpdateZonesDelegate(IntPtr @this, bool value);

		// Token: 0x02000758 RID: 1880
		// (Invoke) Token: 0x06002CCD RID: 11469
		private delegate float get_updatePeriodDelegate(IntPtr @this);

		// Token: 0x02000759 RID: 1881
		// (Invoke) Token: 0x06002CCF RID: 11471
		private delegate void set_updatePeriodDelegate(IntPtr @this, float value);

		// Token: 0x0200075A RID: 1882
		// (Invoke) Token: 0x06002CD1 RID: 11473
		private delegate void get_initializationColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200075B RID: 1883
		// (Invoke) Token: 0x06002CD3 RID: 11475
		private delegate void set_initializationColor_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
