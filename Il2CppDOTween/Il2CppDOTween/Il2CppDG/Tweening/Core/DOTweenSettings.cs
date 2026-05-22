using System;
using Il2CppDG.Tweening.Core.Enums;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppDG.Tweening.Core
{
	// Token: 0x0200004D RID: 77
	public class DOTweenSettings : ScriptableObject
	{
		// Token: 0x060004A7 RID: 1191 RVA: 0x0001BE90 File Offset: 0x0001A090
		// Note: this type is marked as 'beforefieldinit'.
		static DOTweenSettings()
		{
			Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "DOTweenSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr);
			DOTweenSettings.NativeFieldInfoPtr_AssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "AssetName");
			DOTweenSettings.NativeFieldInfoPtr_AssetFullFilename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "AssetFullFilename");
			DOTweenSettings.NativeFieldInfoPtr_useSafeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "useSafeMode");
			DOTweenSettings.NativeFieldInfoPtr_safeModeOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "safeModeOptions");
			DOTweenSettings.NativeFieldInfoPtr_timeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "timeScale");
			DOTweenSettings.NativeFieldInfoPtr_useSmoothDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "useSmoothDeltaTime");
			DOTweenSettings.NativeFieldInfoPtr_maxSmoothUnscaledTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "maxSmoothUnscaledTime");
			DOTweenSettings.NativeFieldInfoPtr_rewindCallbackMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "rewindCallbackMode");
			DOTweenSettings.NativeFieldInfoPtr_showUnityEditorReport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "showUnityEditorReport");
			DOTweenSettings.NativeFieldInfoPtr_logBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "logBehaviour");
			DOTweenSettings.NativeFieldInfoPtr_drawGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "drawGizmos");
			DOTweenSettings.NativeFieldInfoPtr_defaultRecyclable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultRecyclable");
			DOTweenSettings.NativeFieldInfoPtr_defaultAutoPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultAutoPlay");
			DOTweenSettings.NativeFieldInfoPtr_defaultUpdateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultUpdateType");
			DOTweenSettings.NativeFieldInfoPtr_defaultTimeScaleIndependent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultTimeScaleIndependent");
			DOTweenSettings.NativeFieldInfoPtr_defaultEaseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultEaseType");
			DOTweenSettings.NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultEaseOvershootOrAmplitude");
			DOTweenSettings.NativeFieldInfoPtr_defaultEasePeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultEasePeriod");
			DOTweenSettings.NativeFieldInfoPtr_defaultAutoKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultAutoKill");
			DOTweenSettings.NativeFieldInfoPtr_defaultLoopType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "defaultLoopType");
			DOTweenSettings.NativeFieldInfoPtr_showPreviewPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "showPreviewPanel");
			DOTweenSettings.NativeFieldInfoPtr_storeSettingsLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "storeSettingsLocation");
			DOTweenSettings.NativeFieldInfoPtr_modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "modules");
			DOTweenSettings.NativeFieldInfoPtr_showPlayingTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "showPlayingTweens");
			DOTweenSettings.NativeFieldInfoPtr_showPausedTweens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "showPausedTweens");
			DOTweenSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, 100664244);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0001C0C8 File Offset: 0x0001A2C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124696, XrefRangeEnd = 124703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DOTweenSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00003742 File Offset: 0x00001942
		public DOTweenSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0001C104 File Offset: 0x0001A304
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x0000374B File Offset: 0x0000194B
		public unsafe static string AssetName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DOTweenSettings.NativeFieldInfoPtr_AssetName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTweenSettings.NativeFieldInfoPtr_AssetName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0001C124 File Offset: 0x0001A324
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x0000375D File Offset: 0x0000195D
		public unsafe static string AssetFullFilename
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DOTweenSettings.NativeFieldInfoPtr_AssetFullFilename, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DOTweenSettings.NativeFieldInfoPtr_AssetFullFilename, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0001C144 File Offset: 0x0001A344
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x0000376F File Offset: 0x0000196F
		public unsafe bool useSafeMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_useSafeMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_useSafeMode)) = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0001C16C File Offset: 0x0001A36C
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x0000378A File Offset: 0x0000198A
		public unsafe DOTweenSettings.SafeModeOptions safeModeOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_safeModeOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DOTweenSettings.SafeModeOptions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_safeModeOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0001C19C File Offset: 0x0001A39C
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x000037A9 File Offset: 0x000019A9
		public unsafe float timeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_timeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_timeScale)) = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x000037C4 File Offset: 0x000019C4
		public unsafe bool useSmoothDeltaTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_useSmoothDeltaTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_useSmoothDeltaTime)) = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0001C1EC File Offset: 0x0001A3EC
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x000037DF File Offset: 0x000019DF
		public unsafe float maxSmoothUnscaledTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_maxSmoothUnscaledTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_maxSmoothUnscaledTime)) = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0001C214 File Offset: 0x0001A414
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x000037FA File Offset: 0x000019FA
		public unsafe RewindCallbackMode rewindCallbackMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_rewindCallbackMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_rewindCallbackMode)) = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0001C23C File Offset: 0x0001A43C
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00003815 File Offset: 0x00001A15
		public unsafe bool showUnityEditorReport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showUnityEditorReport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showUnityEditorReport)) = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0001C264 File Offset: 0x0001A464
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00003830 File Offset: 0x00001A30
		public unsafe LogBehaviour logBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_logBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_logBehaviour)) = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0001C28C File Offset: 0x0001A48C
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x0000384B File Offset: 0x00001A4B
		public unsafe bool drawGizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_drawGizmos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_drawGizmos)) = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0001C2B4 File Offset: 0x0001A4B4
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00003866 File Offset: 0x00001A66
		public unsafe bool defaultRecyclable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultRecyclable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultRecyclable)) = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x0001C2DC File Offset: 0x0001A4DC
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00003881 File Offset: 0x00001A81
		public unsafe AutoPlay defaultAutoPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultAutoPlay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultAutoPlay)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0001C304 File Offset: 0x0001A504
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x0000389C File Offset: 0x00001A9C
		public unsafe UpdateType defaultUpdateType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultUpdateType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultUpdateType)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0001C32C File Offset: 0x0001A52C
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x000038B7 File Offset: 0x00001AB7
		public unsafe bool defaultTimeScaleIndependent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultTimeScaleIndependent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultTimeScaleIndependent)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0001C354 File Offset: 0x0001A554
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x000038D2 File Offset: 0x00001AD2
		public unsafe Ease defaultEaseType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultEaseType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultEaseType)) = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0001C37C File Offset: 0x0001A57C
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x000038ED File Offset: 0x00001AED
		public unsafe float defaultEaseOvershootOrAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x0001C3A4 File Offset: 0x0001A5A4
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00003908 File Offset: 0x00001B08
		public unsafe float defaultEasePeriod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultEasePeriod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultEasePeriod)) = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0001C3CC File Offset: 0x0001A5CC
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00003923 File Offset: 0x00001B23
		public unsafe bool defaultAutoKill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultAutoKill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultAutoKill)) = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0001C3F4 File Offset: 0x0001A5F4
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x0000393E File Offset: 0x00001B3E
		public unsafe LoopType defaultLoopType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultLoopType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_defaultLoopType)) = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0001C41C File Offset: 0x0001A61C
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00003959 File Offset: 0x00001B59
		public unsafe bool showPreviewPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showPreviewPanel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showPreviewPanel)) = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0001C444 File Offset: 0x0001A644
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00003974 File Offset: 0x00001B74
		public unsafe DOTweenSettings.SettingsLocation storeSettingsLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_storeSettingsLocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_storeSettingsLocation)) = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0001C46C File Offset: 0x0001A66C
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x0000398F File Offset: 0x00001B8F
		public unsafe DOTweenSettings.ModulesSetup modules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_modules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DOTweenSettings.ModulesSetup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0001C49C File Offset: 0x0001A69C
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x000039AE File Offset: 0x00001BAE
		public unsafe bool showPlayingTweens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showPlayingTweens);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showPlayingTweens)) = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x000039C9 File Offset: 0x00001BC9
		public unsafe bool showPausedTweens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showPausedTweens);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.NativeFieldInfoPtr_showPausedTweens)) = value;
			}
		}

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_AssetName;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_AssetFullFilename;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_useSafeMode;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_safeModeOptions;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_timeScale;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_useSmoothDeltaTime;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeFieldInfoPtr_maxSmoothUnscaledTime;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeFieldInfoPtr_rewindCallbackMode;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeFieldInfoPtr_showUnityEditorReport;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeFieldInfoPtr_logBehaviour;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeFieldInfoPtr_drawGizmos;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeFieldInfoPtr_defaultRecyclable;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeFieldInfoPtr_defaultAutoPlay;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeFieldInfoPtr_defaultUpdateType;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeFieldInfoPtr_defaultTimeScaleIndependent;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr_defaultEaseType;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr_defaultEaseOvershootOrAmplitude;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeFieldInfoPtr_defaultEasePeriod;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeFieldInfoPtr_defaultAutoKill;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeFieldInfoPtr_defaultLoopType;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeFieldInfoPtr_showPreviewPanel;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeFieldInfoPtr_storeSettingsLocation;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeFieldInfoPtr_modules;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeFieldInfoPtr_showPlayingTweens;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeFieldInfoPtr_showPausedTweens;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000EC RID: 236
		[OriginalName("DOTween.dll", "", "SettingsLocation")]
		public enum SettingsLocation
		{
			// Token: 0x04000680 RID: 1664
			AssetsDirectory,
			// Token: 0x04000681 RID: 1665
			DOTweenDirectory,
			// Token: 0x04000682 RID: 1666
			DemigiantDirectory
		}

		// Token: 0x020000ED RID: 237
		[Serializable]
		public class SafeModeOptions : global::Il2CppSystem.Object
		{
			// Token: 0x060008CA RID: 2250 RVA: 0x00029848 File Offset: 0x00027A48
			// Note: this type is marked as 'beforefieldinit'.
			static SafeModeOptions()
			{
				Il2CppClassPointerStore<DOTweenSettings.SafeModeOptions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "SafeModeOptions");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenSettings.SafeModeOptions>.NativeClassPtr);
				DOTweenSettings.SafeModeOptions.NativeFieldInfoPtr_nestedTweenFailureBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings.SafeModeOptions>.NativeClassPtr, "nestedTweenFailureBehaviour");
				DOTweenSettings.SafeModeOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenSettings.SafeModeOptions>.NativeClassPtr, 100664245);
			}

			// Token: 0x060008CB RID: 2251 RVA: 0x0002989C File Offset: 0x00027A9C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SafeModeOptions()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenSettings.SafeModeOptions>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenSettings.SafeModeOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060008CC RID: 2252 RVA: 0x0000510B File Offset: 0x0000330B
			public SafeModeOptions(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x060008CD RID: 2253 RVA: 0x000298D8 File Offset: 0x00027AD8
			// (set) Token: 0x060008CE RID: 2254 RVA: 0x00005114 File Offset: 0x00003314
			public unsafe NestedTweenFailureBehaviour nestedTweenFailureBehaviour
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.SafeModeOptions.NativeFieldInfoPtr_nestedTweenFailureBehaviour);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.SafeModeOptions.NativeFieldInfoPtr_nestedTweenFailureBehaviour)) = value;
				}
			}

			// Token: 0x04000683 RID: 1667
			private static readonly IntPtr NativeFieldInfoPtr_nestedTweenFailureBehaviour;

			// Token: 0x04000684 RID: 1668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000EE RID: 238
		[Serializable]
		public class ModulesSetup : global::Il2CppSystem.Object
		{
			// Token: 0x060008CF RID: 2255 RVA: 0x00029900 File Offset: 0x00027B00
			// Note: this type is marked as 'beforefieldinit'.
			static ModulesSetup()
			{
				Il2CppClassPointerStore<DOTweenSettings.ModulesSetup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenSettings>.NativeClassPtr, "ModulesSetup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenSettings.ModulesSetup>.NativeClassPtr);
				DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_showPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings.ModulesSetup>.NativeClassPtr, "showPanel");
				DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_audioEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings.ModulesSetup>.NativeClassPtr, "audioEnabled");
				DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_physicsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings.ModulesSetup>.NativeClassPtr, "physicsEnabled");
				DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_physics2DEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings.ModulesSetup>.NativeClassPtr, "physics2DEnabled");
				DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_spriteEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings.ModulesSetup>.NativeClassPtr, "spriteEnabled");
				DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_uiEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings.ModulesSetup>.NativeClassPtr, "uiEnabled");
				DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_textMeshProEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings.ModulesSetup>.NativeClassPtr, "textMeshProEnabled");
				DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_tk2DEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenSettings.ModulesSetup>.NativeClassPtr, "tk2DEnabled");
				DOTweenSettings.ModulesSetup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenSettings.ModulesSetup>.NativeClassPtr, 100664246);
			}

			// Token: 0x060008D0 RID: 2256 RVA: 0x000299E0 File Offset: 0x00027BE0
			[CallerCount(0)]
			public unsafe ModulesSetup()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenSettings.ModulesSetup>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenSettings.ModulesSetup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060008D1 RID: 2257 RVA: 0x0000512F File Offset: 0x0000332F
			public ModulesSetup(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00029A1C File Offset: 0x00027C1C
			// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00005138 File Offset: 0x00003338
			public unsafe bool showPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_showPanel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_showPanel)) = value;
				}
			}

			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x060008D4 RID: 2260 RVA: 0x00029A44 File Offset: 0x00027C44
			// (set) Token: 0x060008D5 RID: 2261 RVA: 0x00005153 File Offset: 0x00003353
			public unsafe bool audioEnabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_audioEnabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_audioEnabled)) = value;
				}
			}

			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00029A6C File Offset: 0x00027C6C
			// (set) Token: 0x060008D7 RID: 2263 RVA: 0x0000516E File Offset: 0x0000336E
			public unsafe bool physicsEnabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_physicsEnabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_physicsEnabled)) = value;
				}
			}

			// Token: 0x170001B6 RID: 438
			// (get) Token: 0x060008D8 RID: 2264 RVA: 0x00029A94 File Offset: 0x00027C94
			// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00005189 File Offset: 0x00003389
			public unsafe bool physics2DEnabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_physics2DEnabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_physics2DEnabled)) = value;
				}
			}

			// Token: 0x170001B7 RID: 439
			// (get) Token: 0x060008DA RID: 2266 RVA: 0x00029ABC File Offset: 0x00027CBC
			// (set) Token: 0x060008DB RID: 2267 RVA: 0x000051A4 File Offset: 0x000033A4
			public unsafe bool spriteEnabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_spriteEnabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_spriteEnabled)) = value;
				}
			}

			// Token: 0x170001B8 RID: 440
			// (get) Token: 0x060008DC RID: 2268 RVA: 0x00029AE4 File Offset: 0x00027CE4
			// (set) Token: 0x060008DD RID: 2269 RVA: 0x000051BF File Offset: 0x000033BF
			public unsafe bool uiEnabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_uiEnabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_uiEnabled)) = value;
				}
			}

			// Token: 0x170001B9 RID: 441
			// (get) Token: 0x060008DE RID: 2270 RVA: 0x00029B0C File Offset: 0x00027D0C
			// (set) Token: 0x060008DF RID: 2271 RVA: 0x000051DA File Offset: 0x000033DA
			public unsafe bool textMeshProEnabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_textMeshProEnabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_textMeshProEnabled)) = value;
				}
			}

			// Token: 0x170001BA RID: 442
			// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00029B34 File Offset: 0x00027D34
			// (set) Token: 0x060008E1 RID: 2273 RVA: 0x000051F5 File Offset: 0x000033F5
			public unsafe bool tk2DEnabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_tk2DEnabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenSettings.ModulesSetup.NativeFieldInfoPtr_tk2DEnabled)) = value;
				}
			}

			// Token: 0x04000685 RID: 1669
			private static readonly IntPtr NativeFieldInfoPtr_showPanel;

			// Token: 0x04000686 RID: 1670
			private static readonly IntPtr NativeFieldInfoPtr_audioEnabled;

			// Token: 0x04000687 RID: 1671
			private static readonly IntPtr NativeFieldInfoPtr_physicsEnabled;

			// Token: 0x04000688 RID: 1672
			private static readonly IntPtr NativeFieldInfoPtr_physics2DEnabled;

			// Token: 0x04000689 RID: 1673
			private static readonly IntPtr NativeFieldInfoPtr_spriteEnabled;

			// Token: 0x0400068A RID: 1674
			private static readonly IntPtr NativeFieldInfoPtr_uiEnabled;

			// Token: 0x0400068B RID: 1675
			private static readonly IntPtr NativeFieldInfoPtr_textMeshProEnabled;

			// Token: 0x0400068C RID: 1676
			private static readonly IntPtr NativeFieldInfoPtr_tk2DEnabled;

			// Token: 0x0400068D RID: 1677
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
