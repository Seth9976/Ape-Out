using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.U2D
{
	// Token: 0x0200010D RID: 269
	public class SpriteAtlas : Object
	{
		// Token: 0x060016EA RID: 5866 RVA: 0x000590F0 File Offset: 0x000572F0
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteAtlas()
		{
			Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteAtlas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr);
			SpriteAtlas.NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100665338);
			SpriteAtlas.get_isVariantDelegateField = IL2CPP.ResolveICall<SpriteAtlas.get_isVariantDelegate>("UnityEngine.U2D.SpriteAtlas::get_isVariant");
			SpriteAtlas.get_tagDelegateField = IL2CPP.ResolveICall<SpriteAtlas.get_tagDelegate>("UnityEngine.U2D.SpriteAtlas::get_tag");
			SpriteAtlas.get_spriteCountDelegateField = IL2CPP.ResolveICall<SpriteAtlas.get_spriteCountDelegate>("UnityEngine.U2D.SpriteAtlas::get_spriteCount");
			SpriteAtlas.GetSpriteDelegateField = IL2CPP.ResolveICall<SpriteAtlas.GetSpriteDelegate>("UnityEngine.U2D.SpriteAtlas::GetSprite");
			SpriteAtlas.GetSpritesScriptingDelegateField = IL2CPP.ResolveICall<SpriteAtlas.GetSpritesScriptingDelegate>("UnityEngine.U2D.SpriteAtlas::GetSpritesScripting");
			SpriteAtlas.GetSpritesWithNameScriptingDelegateField = IL2CPP.ResolveICall<SpriteAtlas.GetSpritesWithNameScriptingDelegate>("UnityEngine.U2D.SpriteAtlas::GetSpritesWithNameScripting");
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00059190 File Offset: 0x00057390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 500295, RefRangeEnd = 500296, XrefRangeStart = 500291, XrefRangeEnd = 500295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBindTo(Sprite sprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0000C3F8 File Offset: 0x0000A5F8
		public SpriteAtlas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x0000C401 File Offset: 0x0000A601
		public bool isVariant
		{
			get
			{
				return SpriteAtlas.get_isVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x000591E0 File Offset: 0x000573E0
		public string tag
		{
			get
			{
				IntPtr intPtr = SpriteAtlas.get_tagDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x0000C413 File Offset: 0x0000A613
		public int spriteCount
		{
			get
			{
				return SpriteAtlas.get_spriteCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00059204 File Offset: 0x00057404
		public Sprite GetSprite(string name)
		{
			IntPtr intPtr = SpriteAtlas.GetSpriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00059238 File Offset: 0x00057438
		public int GetSprites(Il2CppReferenceArray<Sprite> sprites)
		{
			return this.GetSpritesScripting(sprites);
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00059254 File Offset: 0x00057454
		public int GetSprites(Il2CppReferenceArray<Sprite> sprites, string name)
		{
			return this.GetSpritesWithNameScripting(sprites, name);
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0000C425 File Offset: 0x0000A625
		public int GetSpritesScripting(Il2CppReferenceArray<Sprite> sprites)
		{
			return SpriteAtlas.GetSpritesScriptingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(sprites));
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x0000C43D File Offset: 0x0000A63D
		public int GetSpritesWithNameScripting(Il2CppReferenceArray<Sprite> sprites, string name)
		{
			return SpriteAtlas.GetSpritesWithNameScriptingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(sprites), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly SpriteAtlas.get_isVariantDelegate get_isVariantDelegateField;

		// Token: 0x040011F3 RID: 4595
		private static readonly SpriteAtlas.get_tagDelegate get_tagDelegateField;

		// Token: 0x040011F4 RID: 4596
		private static readonly SpriteAtlas.get_spriteCountDelegate get_spriteCountDelegateField;

		// Token: 0x040011F5 RID: 4597
		private static readonly SpriteAtlas.GetSpriteDelegate GetSpriteDelegateField;

		// Token: 0x040011F6 RID: 4598
		private static readonly SpriteAtlas.GetSpritesScriptingDelegate GetSpritesScriptingDelegateField;

		// Token: 0x040011F7 RID: 4599
		private static readonly SpriteAtlas.GetSpritesWithNameScriptingDelegate GetSpritesWithNameScriptingDelegateField;

		// Token: 0x02000889 RID: 2185
		// (Invoke) Token: 0x06002F1B RID: 12059
		private delegate bool get_isVariantDelegate(IntPtr @this);

		// Token: 0x0200088A RID: 2186
		// (Invoke) Token: 0x06002F1D RID: 12061
		private delegate IntPtr get_tagDelegate(IntPtr @this);

		// Token: 0x0200088B RID: 2187
		// (Invoke) Token: 0x06002F1F RID: 12063
		private delegate int get_spriteCountDelegate(IntPtr @this);

		// Token: 0x0200088C RID: 2188
		// (Invoke) Token: 0x06002F21 RID: 12065
		private delegate IntPtr GetSpriteDelegate(IntPtr @this, IntPtr name);

		// Token: 0x0200088D RID: 2189
		// (Invoke) Token: 0x06002F23 RID: 12067
		private delegate int GetSpritesScriptingDelegate(IntPtr @this, IntPtr sprites);

		// Token: 0x0200088E RID: 2190
		// (Invoke) Token: 0x06002F25 RID: 12069
		private delegate int GetSpritesWithNameScriptingDelegate(IntPtr @this, IntPtr sprites, IntPtr name);
	}
}
