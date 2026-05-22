using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000106 RID: 262
	public sealed class SpriteRenderer : Renderer
	{
		// Token: 0x06001666 RID: 5734 RVA: 0x000578B8 File Offset: 0x00055AB8
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteRenderer()
		{
			Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SpriteRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr);
			SpriteRenderer.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100665290);
			SpriteRenderer.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100665291);
			SpriteRenderer.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100665292);
			SpriteRenderer.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100665293);
			SpriteRenderer.NativeMethodInfoPtr_get_flipX_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100665294);
			SpriteRenderer.NativeMethodInfoPtr_set_flipX_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100665295);
			SpriteRenderer.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100665296);
			SpriteRenderer.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100665297);
			SpriteRenderer.get_shouldSupportTilingDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_shouldSupportTilingDelegate>("UnityEngine.SpriteRenderer::get_shouldSupportTiling");
			SpriteRenderer.get_drawModeDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_drawModeDelegate>("UnityEngine.SpriteRenderer::get_drawMode");
			SpriteRenderer.set_drawModeDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_drawModeDelegate>("UnityEngine.SpriteRenderer::set_drawMode");
			SpriteRenderer.get_adaptiveModeThresholdDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_adaptiveModeThresholdDelegate>("UnityEngine.SpriteRenderer::get_adaptiveModeThreshold");
			SpriteRenderer.set_adaptiveModeThresholdDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_adaptiveModeThresholdDelegate>("UnityEngine.SpriteRenderer::set_adaptiveModeThreshold");
			SpriteRenderer.get_tileModeDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_tileModeDelegate>("UnityEngine.SpriteRenderer::get_tileMode");
			SpriteRenderer.set_tileModeDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_tileModeDelegate>("UnityEngine.SpriteRenderer::set_tileMode");
			SpriteRenderer.get_maskInteractionDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_maskInteractionDelegate>("UnityEngine.SpriteRenderer::get_maskInteraction");
			SpriteRenderer.set_maskInteractionDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_maskInteractionDelegate>("UnityEngine.SpriteRenderer::set_maskInteraction");
			SpriteRenderer.get_flipYDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_flipYDelegate>("UnityEngine.SpriteRenderer::get_flipY");
			SpriteRenderer.set_flipYDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_flipYDelegate>("UnityEngine.SpriteRenderer::set_flipY");
			SpriteRenderer.get_spriteSortPointDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_spriteSortPointDelegate>("UnityEngine.SpriteRenderer::get_spriteSortPoint");
			SpriteRenderer.set_spriteSortPointDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_spriteSortPointDelegate>("UnityEngine.SpriteRenderer::set_spriteSortPoint");
			SpriteRenderer.get_size_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_size_InjectedDelegate>("UnityEngine.SpriteRenderer::get_size_Injected");
			SpriteRenderer.set_size_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_size_InjectedDelegate>("UnityEngine.SpriteRenderer::set_size_Injected");
			SpriteRenderer.Internal_GetSpriteBounds_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRenderer.Internal_GetSpriteBounds_InjectedDelegate>("UnityEngine.SpriteRenderer::Internal_GetSpriteBounds_Injected");
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x00057A78 File Offset: 0x00055C78
		// (set) Token: 0x06001668 RID: 5736 RVA: 0x00057AB8 File Offset: 0x00055CB8
		public unsafe Sprite sprite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500055, XrefRangeEnd = 500059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 500063, RefRangeEnd = 500075, XrefRangeStart = 500059, XrefRangeEnd = 500063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x00057AFC File Offset: 0x00055CFC
		// (set) Token: 0x0600166A RID: 5738 RVA: 0x00057B38 File Offset: 0x00055D38
		public unsafe Color color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500075, XrefRangeEnd = 500077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 500079, RefRangeEnd = 500080, XrefRangeStart = 500077, XrefRangeEnd = 500079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x00057B78 File Offset: 0x00055D78
		// (set) Token: 0x0600166C RID: 5740 RVA: 0x00057BB4 File Offset: 0x00055DB4
		public unsafe bool flipX
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500080, XrefRangeEnd = 500084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_flipX_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 500088, RefRangeEnd = 500089, XrefRangeStart = 500084, XrefRangeEnd = 500088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_flipX_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00057BF4 File Offset: 0x00055DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500089, XrefRangeEnd = 500093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_color_Injected(out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00057C34 File Offset: 0x00055E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500093, XrefRangeEnd = 500097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_color_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0000C0AD File Offset: 0x0000A2AD
		public SpriteRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x0000C0B6 File Offset: 0x0000A2B6
		public bool shouldSupportTiling
		{
			get
			{
				return SpriteRenderer.get_shouldSupportTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x0000C0C8 File Offset: 0x0000A2C8
		// (set) Token: 0x06001672 RID: 5746 RVA: 0x0000C0DA File Offset: 0x0000A2DA
		public SpriteDrawMode drawMode
		{
			get
			{
				return SpriteRenderer.get_drawModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_drawModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x00057C74 File Offset: 0x00055E74
		// (set) Token: 0x06001674 RID: 5748 RVA: 0x0000C0ED File Offset: 0x0000A2ED
		public Vector2 size
		{
			get
			{
				Vector2 vector;
				this.get_size_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x0000C0F7 File Offset: 0x0000A2F7
		// (set) Token: 0x06001676 RID: 5750 RVA: 0x0000C109 File Offset: 0x0000A309
		public float adaptiveModeThreshold
		{
			get
			{
				return SpriteRenderer.get_adaptiveModeThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_adaptiveModeThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x0000C11C File Offset: 0x0000A31C
		// (set) Token: 0x06001678 RID: 5752 RVA: 0x0000C12E File Offset: 0x0000A32E
		public SpriteTileMode tileMode
		{
			get
			{
				return SpriteRenderer.get_tileModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_tileModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x0000C141 File Offset: 0x0000A341
		// (set) Token: 0x0600167A RID: 5754 RVA: 0x0000C153 File Offset: 0x0000A353
		public SpriteMaskInteraction maskInteraction
		{
			get
			{
				return SpriteRenderer.get_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x0000C166 File Offset: 0x0000A366
		// (set) Token: 0x0600167C RID: 5756 RVA: 0x0000C178 File Offset: 0x0000A378
		public bool flipY
		{
			get
			{
				return SpriteRenderer.get_flipYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_flipYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x0000C18B File Offset: 0x0000A38B
		// (set) Token: 0x0600167E RID: 5758 RVA: 0x0000C19D File Offset: 0x0000A39D
		public SpriteSortPoint spriteSortPoint
		{
			get
			{
				return SpriteRenderer.get_spriteSortPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_spriteSortPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00057C8C File Offset: 0x00055E8C
		public Bounds Internal_GetSpriteBounds(SpriteDrawMode mode)
		{
			Bounds bounds;
			this.Internal_GetSpriteBounds_Injected(mode, out bounds);
			return bounds;
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00057CA4 File Offset: 0x00055EA4
		public Bounds GetSpriteBounds()
		{
			return this.Internal_GetSpriteBounds(this.drawMode);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		public void get_size_Injected(out Vector2 ret)
		{
			SpriteRenderer.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x0000C1C3 File Offset: 0x0000A3C3
		public void set_size_Injected(ref Vector2 value)
		{
			SpriteRenderer.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0000C1D6 File Offset: 0x0000A3D6
		public void Internal_GetSpriteBounds_Injected(SpriteDrawMode mode, out Bounds ret)
		{
			SpriteRenderer.Internal_GetSpriteBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mode, out ret);
		}

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_get_flipX_Public_get_Boolean_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_set_flipX_Public_set_Void_Boolean_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Void_byref_Color_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly SpriteRenderer.get_shouldSupportTilingDelegate get_shouldSupportTilingDelegateField;

		// Token: 0x040011A5 RID: 4517
		private static readonly SpriteRenderer.get_drawModeDelegate get_drawModeDelegateField;

		// Token: 0x040011A6 RID: 4518
		private static readonly SpriteRenderer.set_drawModeDelegate set_drawModeDelegateField;

		// Token: 0x040011A7 RID: 4519
		private static readonly SpriteRenderer.get_adaptiveModeThresholdDelegate get_adaptiveModeThresholdDelegateField;

		// Token: 0x040011A8 RID: 4520
		private static readonly SpriteRenderer.set_adaptiveModeThresholdDelegate set_adaptiveModeThresholdDelegateField;

		// Token: 0x040011A9 RID: 4521
		private static readonly SpriteRenderer.get_tileModeDelegate get_tileModeDelegateField;

		// Token: 0x040011AA RID: 4522
		private static readonly SpriteRenderer.set_tileModeDelegate set_tileModeDelegateField;

		// Token: 0x040011AB RID: 4523
		private static readonly SpriteRenderer.get_maskInteractionDelegate get_maskInteractionDelegateField;

		// Token: 0x040011AC RID: 4524
		private static readonly SpriteRenderer.set_maskInteractionDelegate set_maskInteractionDelegateField;

		// Token: 0x040011AD RID: 4525
		private static readonly SpriteRenderer.get_flipYDelegate get_flipYDelegateField;

		// Token: 0x040011AE RID: 4526
		private static readonly SpriteRenderer.set_flipYDelegate set_flipYDelegateField;

		// Token: 0x040011AF RID: 4527
		private static readonly SpriteRenderer.get_spriteSortPointDelegate get_spriteSortPointDelegateField;

		// Token: 0x040011B0 RID: 4528
		private static readonly SpriteRenderer.set_spriteSortPointDelegate set_spriteSortPointDelegateField;

		// Token: 0x040011B1 RID: 4529
		private static readonly SpriteRenderer.get_size_InjectedDelegate get_size_InjectedDelegateField;

		// Token: 0x040011B2 RID: 4530
		private static readonly SpriteRenderer.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x040011B3 RID: 4531
		private static readonly SpriteRenderer.Internal_GetSpriteBounds_InjectedDelegate Internal_GetSpriteBounds_InjectedDelegateField;

		// Token: 0x0200086D RID: 2157
		// (Invoke) Token: 0x06002EE3 RID: 12003
		private delegate bool get_shouldSupportTilingDelegate(IntPtr @this);

		// Token: 0x0200086E RID: 2158
		// (Invoke) Token: 0x06002EE5 RID: 12005
		private delegate SpriteDrawMode get_drawModeDelegate(IntPtr @this);

		// Token: 0x0200086F RID: 2159
		// (Invoke) Token: 0x06002EE7 RID: 12007
		private delegate void set_drawModeDelegate(IntPtr @this, SpriteDrawMode value);

		// Token: 0x02000870 RID: 2160
		// (Invoke) Token: 0x06002EE9 RID: 12009
		private delegate float get_adaptiveModeThresholdDelegate(IntPtr @this);

		// Token: 0x02000871 RID: 2161
		// (Invoke) Token: 0x06002EEB RID: 12011
		private delegate void set_adaptiveModeThresholdDelegate(IntPtr @this, float value);

		// Token: 0x02000872 RID: 2162
		// (Invoke) Token: 0x06002EED RID: 12013
		private delegate SpriteTileMode get_tileModeDelegate(IntPtr @this);

		// Token: 0x02000873 RID: 2163
		// (Invoke) Token: 0x06002EEF RID: 12015
		private delegate void set_tileModeDelegate(IntPtr @this, SpriteTileMode value);

		// Token: 0x02000874 RID: 2164
		// (Invoke) Token: 0x06002EF1 RID: 12017
		private delegate SpriteMaskInteraction get_maskInteractionDelegate(IntPtr @this);

		// Token: 0x02000875 RID: 2165
		// (Invoke) Token: 0x06002EF3 RID: 12019
		private delegate void set_maskInteractionDelegate(IntPtr @this, SpriteMaskInteraction value);

		// Token: 0x02000876 RID: 2166
		// (Invoke) Token: 0x06002EF5 RID: 12021
		private delegate bool get_flipYDelegate(IntPtr @this);

		// Token: 0x02000877 RID: 2167
		// (Invoke) Token: 0x06002EF7 RID: 12023
		private delegate void set_flipYDelegate(IntPtr @this, bool value);

		// Token: 0x02000878 RID: 2168
		// (Invoke) Token: 0x06002EF9 RID: 12025
		private delegate SpriteSortPoint get_spriteSortPointDelegate(IntPtr @this);

		// Token: 0x02000879 RID: 2169
		// (Invoke) Token: 0x06002EFB RID: 12027
		private delegate void set_spriteSortPointDelegate(IntPtr @this, SpriteSortPoint value);

		// Token: 0x0200087A RID: 2170
		// (Invoke) Token: 0x06002EFD RID: 12029
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200087B RID: 2171
		// (Invoke) Token: 0x06002EFF RID: 12031
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200087C RID: 2172
		// (Invoke) Token: 0x06002F01 RID: 12033
		private delegate void Internal_GetSpriteBounds_InjectedDelegate(IntPtr @this, SpriteDrawMode mode, [Out] IntPtr ret);
	}
}
