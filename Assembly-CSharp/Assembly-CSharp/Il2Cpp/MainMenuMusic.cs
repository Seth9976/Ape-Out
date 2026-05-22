using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000009 RID: 9
	public class MainMenuMusic : MonoBehaviour
	{
		// Token: 0x0600009D RID: 157 RVA: 0x00035F68 File Offset: 0x00034168
		// Note: this type is marked as 'beforefieldinit'.
		static MainMenuMusic()
		{
			Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MainMenuMusic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr);
			MainMenuMusic.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "me");
			MainMenuMusic.NativeFieldInfoPtr_SourceA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "SourceA");
			MainMenuMusic.NativeFieldInfoPtr_SourceB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "SourceB");
			MainMenuMusic.NativeFieldInfoPtr_MenuMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "MenuMusic");
			MainMenuMusic.NativeFieldInfoPtr_sourceAFadingIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "sourceAFadingIn");
			MainMenuMusic.NativeFieldInfoPtr_sourceBFadingIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "sourceBFadingIn");
			MainMenuMusic.NativeFieldInfoPtr_sourceAStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "sourceAStartTime");
			MainMenuMusic.NativeFieldInfoPtr_sourceBStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "sourceBStartTime");
			MainMenuMusic.NativeFieldInfoPtr_dspTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "dspTime");
			MainMenuMusic.NativeFieldInfoPtr_SourceAIsNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "SourceAIsNext");
			MainMenuMusic.NativeFieldInfoPtr_FadeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "FadeLength");
			MainMenuMusic.NativeFieldInfoPtr_NoMenuMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "NoMenuMusic");
			MainMenuMusic.NativeFieldInfoPtr_fadingOutMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "fadingOutMusic");
			MainMenuMusic.NativeFieldInfoPtr_musicFadeStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "musicFadeStartTime");
			MainMenuMusic.NativeFieldInfoPtr_SourceAIsFading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, "SourceAIsFading");
			MainMenuMusic.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, 100663330);
			MainMenuMusic.NativeMethodInfoPtr_PlayMenuMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, 100663331);
			MainMenuMusic.NativeMethodInfoPtr_DisableMenuMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, 100663332);
			MainMenuMusic.NativeMethodInfoPtr_FadeOutMenuMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, 100663333);
			MainMenuMusic.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, 100663334);
			MainMenuMusic.NativeMethodInfoPtr_UpdateFade_Private_Void_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, 100663335);
			MainMenuMusic.NativeMethodInfoPtr_UpdateSources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, 100663336);
			MainMenuMusic.NativeMethodInfoPtr_CueNextClip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, 100663337);
			MainMenuMusic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr, 100663338);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00036178 File Offset: 0x00034378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30555, XrefRangeEnd = 30587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuMusic.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000361AC File Offset: 0x000343AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30609, RefRangeEnd = 30610, XrefRangeStart = 30587, XrefRangeEnd = 30609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMenuMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuMusic.NativeMethodInfoPtr_PlayMenuMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000361E0 File Offset: 0x000343E0
		[CallerCount(0)]
		public unsafe void DisableMenuMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuMusic.NativeMethodInfoPtr_DisableMenuMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00036214 File Offset: 0x00034414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30610, XrefRangeEnd = 30615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FadeOutMenuMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuMusic.NativeMethodInfoPtr_FadeOutMenuMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00036248 File Offset: 0x00034448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30615, XrefRangeEnd = 30620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuMusic.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0003627C File Offset: 0x0003447C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 30626, RefRangeEnd = 30629, XrefRangeStart = 30620, XrefRangeEnd = 30626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFade(AudioSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuMusic.NativeMethodInfoPtr_UpdateFade_Private_Void_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000362C0 File Offset: 0x000344C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30633, RefRangeEnd = 30634, XrefRangeStart = 30629, XrefRangeEnd = 30633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuMusic.NativeMethodInfoPtr_UpdateSources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000362F4 File Offset: 0x000344F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30653, RefRangeEnd = 30654, XrefRangeStart = 30634, XrefRangeEnd = 30653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CueNextClip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuMusic.NativeMethodInfoPtr_CueNextClip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00036328 File Offset: 0x00034528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30654, XrefRangeEnd = 30657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainMenuMusic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuMusic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuMusic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000270F File Offset: 0x0000090F
		public MainMenuMusic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00036364 File Offset: 0x00034564
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002718 File Offset: 0x00000918
		public unsafe static MainMenuMusic me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MainMenuMusic.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuMusic>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MainMenuMusic.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0003638C File Offset: 0x0003458C
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000272A File Offset: 0x0000092A
		public unsafe AudioSource SourceA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_SourceA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_SourceA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000363BC File Offset: 0x000345BC
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002749 File Offset: 0x00000949
		public unsafe AudioSource SourceB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_SourceB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_SourceB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000363EC File Offset: 0x000345EC
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002768 File Offset: 0x00000968
		public unsafe AudioClip MenuMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_MenuMusic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_MenuMusic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0003641C File Offset: 0x0003461C
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002787 File Offset: 0x00000987
		public unsafe bool sourceAFadingIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_sourceAFadingIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_sourceAFadingIn)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00036444 File Offset: 0x00034644
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000027A2 File Offset: 0x000009A2
		public unsafe bool sourceBFadingIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_sourceBFadingIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_sourceBFadingIn)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0003646C File Offset: 0x0003466C
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000027BD File Offset: 0x000009BD
		public unsafe double sourceAStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_sourceAStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_sourceAStartTime)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00036494 File Offset: 0x00034694
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000027D8 File Offset: 0x000009D8
		public unsafe double sourceBStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_sourceBStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_sourceBStartTime)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000364BC File Offset: 0x000346BC
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000027F3 File Offset: 0x000009F3
		public unsafe double dspTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_dspTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_dspTime)) = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000364E4 File Offset: 0x000346E4
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000280E File Offset: 0x00000A0E
		public unsafe bool SourceAIsNext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_SourceAIsNext);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_SourceAIsNext)) = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0003650C File Offset: 0x0003470C
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002829 File Offset: 0x00000A29
		public unsafe float FadeLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_FadeLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_FadeLength)) = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00036534 File Offset: 0x00034734
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002844 File Offset: 0x00000A44
		public unsafe bool NoMenuMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_NoMenuMusic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_NoMenuMusic)) = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0003655C File Offset: 0x0003475C
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000285F File Offset: 0x00000A5F
		public unsafe bool fadingOutMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_fadingOutMusic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_fadingOutMusic)) = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00036584 File Offset: 0x00034784
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000287A File Offset: 0x00000A7A
		public unsafe double musicFadeStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_musicFadeStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_musicFadeStartTime)) = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000365AC File Offset: 0x000347AC
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002895 File Offset: 0x00000A95
		public unsafe bool SourceAIsFading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_SourceAIsFading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuMusic.NativeFieldInfoPtr_SourceAIsFading)) = value;
			}
		}

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_SourceA;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_SourceB;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_MenuMusic;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_sourceAFadingIn;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_sourceBFadingIn;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_sourceAStartTime;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_sourceBStartTime;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_dspTime;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_SourceAIsNext;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_FadeLength;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_NoMenuMusic;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_fadingOutMusic;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_musicFadeStartTime;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_SourceAIsFading;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_PlayMenuMusic_Public_Void_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_DisableMenuMusic_Public_Void_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_FadeOutMenuMusic_Public_Void_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFade_Private_Void_AudioSource_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSources_Private_Void_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_CueNextClip_Private_Void_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
