using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000066 RID: 102
	public class TextureLerper : Object
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x0001A27C File Offset: 0x0001847C
		// Note: this type is marked as 'beforefieldinit'.
		static TextureLerper()
		{
			Il2CppClassPointerStore<TextureLerper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "TextureLerper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr);
			TextureLerper.NativeFieldInfoPtr_m_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, "m_Instance");
			TextureLerper.NativeFieldInfoPtr_m_Command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, "m_Command");
			TextureLerper.NativeFieldInfoPtr_m_PropertySheets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, "m_PropertySheets");
			TextureLerper.NativeFieldInfoPtr_m_Resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, "m_Resources");
			TextureLerper.NativeFieldInfoPtr_m_Recycled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, "m_Recycled");
			TextureLerper.NativeFieldInfoPtr_m_Actives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, "m_Actives");
			TextureLerper.NativeMethodInfoPtr_get_instance_Internal_Static_get_TextureLerper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, 100663888);
			TextureLerper.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, 100663889);
			TextureLerper.NativeMethodInfoPtr_BeginFrame_Internal_Void_PostProcessRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, 100663890);
			TextureLerper.NativeMethodInfoPtr_EndFrame_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, 100663891);
			TextureLerper.NativeMethodInfoPtr_Get_Private_RenderTexture_RenderTextureFormat_Int32_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, 100663892);
			TextureLerper.NativeMethodInfoPtr_Lerp_Internal_Texture_Texture_Texture_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, 100663893);
			TextureLerper.NativeMethodInfoPtr_Lerp_Internal_Texture_Texture_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, 100663894);
			TextureLerper.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr, 100663895);
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0001A3C4 File Offset: 0x000185C4
		public unsafe static TextureLerper instance
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 449995, RefRangeEnd = 450004, XrefRangeStart = 449980, XrefRangeEnd = 449995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureLerper.NativeMethodInfoPtr_get_instance_Internal_Static_get_TextureLerper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextureLerper>(intPtr3) : null;
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0001A3F8 File Offset: 0x000185F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 450004, XrefRangeEnd = 450014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureLerper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureLerper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureLerper.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0001A434 File Offset: 0x00018634
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 450014, RefRangeEnd = 450018, XrefRangeStart = 450014, XrefRangeEnd = 450014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginFrame(PostProcessRenderContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureLerper.NativeMethodInfoPtr_BeginFrame_Internal_Void_PostProcessRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0001A478 File Offset: 0x00018678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 450041, RefRangeEnd = 450042, XrefRangeStart = 450018, XrefRangeEnd = 450041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureLerper.NativeMethodInfoPtr_EndFrame_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0001A4AC File Offset: 0x000186AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 450079, RefRangeEnd = 450082, XrefRangeStart = 450042, XrefRangeEnd = 450079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = false, bool force3D = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableRandomWrite;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force3D;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureLerper.NativeMethodInfoPtr_Get_Private_RenderTexture_RenderTextureFormat_Int32_Int32_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0001A540 File Offset: 0x00018740
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 450158, RefRangeEnd = 450159, XrefRangeStart = 450082, XrefRangeEnd = 450158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture Lerp(Texture from, Texture to, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureLerper.NativeMethodInfoPtr_Lerp_Internal_Texture_Texture_Texture_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0001A5B0 File Offset: 0x000187B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 450192, RefRangeEnd = 450194, XrefRangeStart = 450159, XrefRangeEnd = 450192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture Lerp(Texture from, Color to, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureLerper.NativeMethodInfoPtr_Lerp_Internal_Texture_Texture_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001A61C File Offset: 0x0001881C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 450216, RefRangeEnd = 450217, XrefRangeStart = 450194, XrefRangeEnd = 450216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureLerper.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00005530 File Offset: 0x00003730
		public TextureLerper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x0001A650 File Offset: 0x00018850
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x00005539 File Offset: 0x00003739
		public unsafe static TextureLerper m_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureLerper.NativeFieldInfoPtr_m_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureLerper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureLerper.NativeFieldInfoPtr_m_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x0001A678 File Offset: 0x00018878
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x0000554B File Offset: 0x0000374B
		public unsafe CommandBuffer m_Command
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureLerper.NativeFieldInfoPtr_m_Command);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureLerper.NativeFieldInfoPtr_m_Command), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x0001A6A8 File Offset: 0x000188A8
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x0000556A File Offset: 0x0000376A
		public unsafe PropertySheetFactory m_PropertySheets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureLerper.NativeFieldInfoPtr_m_PropertySheets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySheetFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureLerper.NativeFieldInfoPtr_m_PropertySheets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0001A6D8 File Offset: 0x000188D8
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00005589 File Offset: 0x00003789
		public unsafe PostProcessResources m_Resources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureLerper.NativeFieldInfoPtr_m_Resources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureLerper.NativeFieldInfoPtr_m_Resources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x0001A708 File Offset: 0x00018908
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x000055A8 File Offset: 0x000037A8
		public unsafe List<RenderTexture> m_Recycled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureLerper.NativeFieldInfoPtr_m_Recycled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RenderTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureLerper.NativeFieldInfoPtr_m_Recycled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0001A738 File Offset: 0x00018938
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x000055C7 File Offset: 0x000037C7
		public unsafe List<RenderTexture> m_Actives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureLerper.NativeFieldInfoPtr_m_Actives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RenderTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureLerper.NativeFieldInfoPtr_m_Actives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr_m_Instance;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeFieldInfoPtr_m_Command;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertySheets;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeFieldInfoPtr_m_Resources;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr_m_Recycled;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr_m_Actives;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Internal_Static_get_TextureLerper_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_BeginFrame_Internal_Void_PostProcessRenderContext_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_EndFrame_Internal_Void_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_Get_Private_RenderTexture_RenderTextureFormat_Int32_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Internal_Texture_Texture_Texture_Single_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Internal_Texture_Texture_Color_Single_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;
	}
}
