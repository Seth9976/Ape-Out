using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x020002CB RID: 715
	public sealed class TokenizerStringBlock : Object
	{
		// Token: 0x06003087 RID: 12423 RVA: 0x000F5544 File Offset: 0x000F3744
		// Note: this type is marked as 'beforefieldinit'.
		static TokenizerStringBlock()
		{
			Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "TokenizerStringBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr);
			TokenizerStringBlock.NativeFieldInfoPtr_m_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr, "m_block");
			TokenizerStringBlock.NativeFieldInfoPtr_m_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr, "m_next");
			TokenizerStringBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr, 100671018);
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x000F55B0 File Offset: 0x000F37B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208361, RefRangeEnd = 208364, XrefRangeStart = 208358, XrefRangeEnd = 208361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenizerStringBlock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenizerStringBlock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStringBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003089 RID: 12425 RVA: 0x00010D5F File Offset: 0x0000EF5F
		public TokenizerStringBlock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x000F55EC File Offset: 0x000F37EC
		// (set) Token: 0x0600308B RID: 12427 RVA: 0x00010D68 File Offset: 0x0000EF68
		public unsafe Il2CppStringArray m_block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStringBlock.NativeFieldInfoPtr_m_block);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStringBlock.NativeFieldInfoPtr_m_block), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x000F561C File Offset: 0x000F381C
		// (set) Token: 0x0600308D RID: 12429 RVA: 0x00010D87 File Offset: 0x0000EF87
		public unsafe TokenizerStringBlock m_next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStringBlock.NativeFieldInfoPtr_m_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerStringBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStringBlock.NativeFieldInfoPtr_m_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040029CF RID: 10703
		private static readonly IntPtr NativeFieldInfoPtr_m_block;

		// Token: 0x040029D0 RID: 10704
		private static readonly IntPtr NativeFieldInfoPtr_m_next;

		// Token: 0x040029D1 RID: 10705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
