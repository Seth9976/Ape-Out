using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000064 RID: 100
	public sealed class LightmapData : Object
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x00026CAC File Offset: 0x00024EAC
		// Note: this type is marked as 'beforefieldinit'.
		static LightmapData()
		{
			Il2CppClassPointerStore<LightmapData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightmapData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapData>.NativeClassPtr);
			LightmapData.NativeFieldInfoPtr_m_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightmapData>.NativeClassPtr, "m_Light");
			LightmapData.NativeFieldInfoPtr_m_Dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightmapData>.NativeClassPtr, "m_Dir");
			LightmapData.NativeFieldInfoPtr_m_ShadowMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightmapData>.NativeClassPtr, "m_ShadowMask");
			LightmapData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapData>.NativeClassPtr, 100663821);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00026D2C File Offset: 0x00024F2C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightmapData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightmapData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000569E File Offset: 0x0000389E
		public LightmapData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00026D68 File Offset: 0x00024F68
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x000056A7 File Offset: 0x000038A7
		public unsafe Texture2D m_Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00026D98 File Offset: 0x00024F98
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x000056C6 File Offset: 0x000038C6
		public unsafe Texture2D m_Dir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_Dir);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_Dir), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00026DC8 File Offset: 0x00024FC8
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x000056E5 File Offset: 0x000038E5
		public unsafe Texture2D m_ShadowMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_ShadowMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_ShadowMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00026DF8 File Offset: 0x00024FF8
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x00005704 File Offset: 0x00003904
		public Texture2D lightmapLight
		{
			get
			{
				return this.m_Light;
			}
			set
			{
				this.m_Light = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00026E10 File Offset: 0x00025010
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x0000570E File Offset: 0x0000390E
		public Texture2D lightmapColor
		{
			get
			{
				return this.m_Light;
			}
			set
			{
				this.m_Light = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00026E28 File Offset: 0x00025028
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00005718 File Offset: 0x00003918
		public Texture2D lightmapDir
		{
			get
			{
				return this.m_Dir;
			}
			set
			{
				this.m_Dir = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00026E40 File Offset: 0x00025040
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00005722 File Offset: 0x00003922
		public Texture2D shadowMask
		{
			get
			{
				return this.m_ShadowMask;
			}
			set
			{
				this.m_ShadowMask = value;
			}
		}

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_m_Light;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr_m_Dir;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowMask;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
