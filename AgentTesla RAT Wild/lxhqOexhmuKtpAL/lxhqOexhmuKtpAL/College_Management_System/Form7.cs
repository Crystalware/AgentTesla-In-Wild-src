using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using College_Management_System.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace College_Management_System
{
	// Token: 0x02000017 RID: 23
	[DesignerGenerated]
	public class Form7 : Form
	{
		// Token: 0x060001CE RID: 462 RVA: 0x00019F24 File Offset: 0x00018124
		public Form7()
		{
			for (;;)
			{
				IL_9E:
				int num = Form2.uwpnsrqhswlmjh(44);
				int num2 = -2;
				for (;;)
				{
					num2 ^= 79;
					for (;;)
					{
						IL_49:
						int num3 = 1;
						int num4 = 1;
						for (;;)
						{
							switch (num4 ^ 76)
							{
							case 74:
								switch (num3)
								{
								case 74:
									switch (num2 + 82)
									{
									case 0:
										goto IL_90;
									case 1:
										goto IL_9E;
									case 2:
										switch (num + 69)
										{
										case 0:
											this.rs = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000535-0000-0010-8000-00AA006D2EA4")));
											num = -5;
											goto IL_11;
										case 1:
											this.mqgfoefwabbyer();
											num = -7;
											goto IL_11;
										case 2:
											this.con = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000514-0000-0010-8000-00AA006D2EA4")));
											num = Form2.uwpnsrqhswlmjh(42);
											goto IL_11;
										case 3:
											num = -121;
											goto IL_11;
										case 4:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form7.set_txtPassword(TextBox)).MethodHandle;
											num = -8;
											goto IL_11;
										}
										case 5:
											return;
										}
										goto Block_2;
									case 3:
										break;
									default:
										num3 = 0;
										goto IL_1F;
									}
									IL_11:
									num ^= 71;
									break;
								case 75:
									break;
								case 76:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form7.mqgfoefwabbyer()).MethodHandle;
									num3 = 7;
									goto IL_1F;
								}
								case 77:
									goto IL_8E;
								default:
									num4 = 7;
									continue;
								}
								num2 = Form7.mqgfoefwabbyeu(25);
								num3 = 6;
								goto IL_1F;
							case 75:
								goto IL_49;
							case 76:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form7.mqgfoefwabbyer()).MethodHandle;
								num4 = 0;
								continue;
							}
							case 77:
								goto IL_1F;
							}
							IL_38:
							num4 = 6;
							continue;
							IL_1F:
							num3 ^= 75;
							goto IL_38;
						}
					}
					IL_8E:
					continue;
					IL_90:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form7.get_Label3()).MethodHandle;
					num2 = -31;
					continue;
					Block_2:
					num2 = Form12.wsyoqrrjsoniul(48);
				}
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001A0D8 File Offset: 0x000182D8
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					for (;;)
					{
						IL_131:
						int num = Form2.uwpnsrqhswlmjh(47);
						int num2 = 25;
						for (;;)
						{
							num2 ^= 73;
							for (;;)
							{
								IL_85:
								int num3 = 24;
								int num4 = Form12.wsyoqrrjsoniul(40);
								for (;;)
								{
									num4 ^= 70;
									switch (num4 + 69)
									{
									case 0:
										goto IL_85;
									case 1:
										switch (num3)
										{
										case 71:
											break;
										case 72:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form7.get_txtUsername()).MethodHandle;
											num3 = 25;
											goto IL_4F;
										}
										case 73:
											switch (num2)
											{
											case 77:
												switch (num + 77)
												{
												case 0:
													this.components.Dispose();
													num = -25;
													goto IL_3E;
												case 1:
												{
													RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form7..ctor()).MethodHandle;
													num = -26;
													goto IL_3E;
												}
												case 2:
													num = -28;
													goto IL_3E;
												case 3:
													goto IL_190;
												}
												goto Block_6;
											case 78:
												goto IL_11B;
											case 79:
												goto IL_131;
											case 80:
												break;
											default:
												num3 = 22;
												goto IL_4F;
											}
											IL_3E:
											num ^= 82;
											break;
										case 74:
											goto IL_F6;
										default:
											num4 = -3;
											continue;
										}
										num2 = 4;
										num3 = 27;
										break;
									case 2:
									{
										RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form7.get_txtUsername()).MethodHandle;
										num4 = -5;
										continue;
									}
									case 3:
										break;
									default:
										IL_7A:
										num4 = Form2.uwpnsrqhswlmjh(44);
										continue;
									}
									IL_4F:
									num3 ^= 81;
									goto IL_7A;
								}
							}
							IL_F6:
							continue;
							Block_6:
							num2 = 6;
							continue;
							IL_11B:
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form7.mqgfoefwabbyes(object, EventArgs)).MethodHandle;
							num2 = 7;
						}
					}
					IL_190:;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001A2A0 File Offset: 0x000184A0
		[DebuggerStepThrough]
		private void mqgfoefwabbyer()
		{
			for (;;)
			{
				int num = 16;
				for (;;)
				{
					num ^= 74;
					switch (num)
					{
					case 79:
						this.Label3.Margin = new Padding(4, 0, 4, 0);
						this.Label3.Name = "Label3";
						this.Label3.Size = new Size(73, 17);
						this.Label3.TabIndex = 30;
						num = 24;
						continue;
					case 80:
						base.Controls.Add(this.cmdCancel);
						base.Controls.Add(this.cmdLogin);
						base.Controls.Add(this.txtPassword);
						num = 23;
						continue;
					case 81:
						this.Label2.Location = new Point(77, 117);
						for (;;)
						{
							int num2 = Form8.nxfpeikhibypgs(82);
							for (;;)
							{
								num2 ^= 80;
								switch (num2 + 69)
								{
								case 0:
									this.Label2.Size = new Size(77, 17);
									num2 = Form8.nxfpeikhibypgs(78);
									continue;
								case 1:
									this.Label2.Margin = new Padding(4, 0, 4, 0);
									num2 = -110;
									continue;
								case 2:
									this.Label2.Name = "Label2";
									num2 = -17;
									continue;
								case 3:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form7.get_Label2()).MethodHandle;
									num2 = -18;
									continue;
								}
								case 4:
									num2 = -21;
									continue;
								case 5:
									num2 = -20;
									continue;
								case 6:
									num = 43;
									num2 = -109;
									continue;
								case 7:
									num2 = -19;
									continue;
								case 8:
									goto IL_184;
								}
								break;
							}
						}
						IL_184:
						continue;
					case 82:
						this.Label3.Text = "Password:";
						this.Label2.AutoSize = true;
						this.Label2.BackColor = Color.FromArgb(255, 128, 0);
						num = 27;
						continue;
					case 83:
						this.Label3.AutoSize = true;
						this.Label3.BackColor = Color.FromArgb(255, 128, 0);
						this.Label3.Location = new Point(83, 186);
						num = 5;
						continue;
					case 84:
						this.cmdLogin.Location = new Point(87, 319);
						for (;;)
						{
							int num3 = Form2.uwpnsrqhswlmjh(50);
							for (;;)
							{
								num3 ^= 86;
								switch (num3 + 81)
								{
								case 0:
									this.cmdLogin.Size = new Size(123, 38);
									num3 = -27;
									continue;
								case 1:
									this.cmdLogin.Name = "cmdLogin";
									num3 = -28;
									continue;
								case 2:
									num3 = -32;
									continue;
								case 3:
									num3 = -7;
									continue;
								case 4:
									num = 21;
									num3 = -31;
									continue;
								case 5:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form7.Dispose(bool)).MethodHandle;
									num3 = -30;
									continue;
								}
								case 6:
									num3 = -26;
									continue;
								case 7:
									this.cmdLogin.Margin = new Padding(4, 4, 4, 4);
									num3 = -29;
									continue;
								case 8:
									goto IL_2F1;
								}
								break;
							}
						}
						IL_2F1:
						continue;
					case 85:
						this.txtPassword.Size = new Size(213, 23);
						this.txtPassword.TabIndex = 32;
						this.txtUsername.Location = new Point(212, 117);
						num = 46;
						continue;
					case 86:
						this.cmdCancel.Margin = new Padding(4, 4, 4, 4);
						this.cmdCancel.Name = "cmdCancel";
						this.cmdCancel.Size = new Size(123, 38);
						this.cmdCancel.TabIndex = 34;
						num = 19;
						continue;
					case 87:
						this.txtUsername = new TextBox();
						this.Label3 = new Label();
						this.Label2 = new Label();
						this.Label1 = new Label();
						num = 42;
						continue;
					case 88:
					{
						base.AutoScaleDimensions = new SizeF(8f, 16f);
						base.AutoScaleMode = AutoScaleMode.Font;
						ComponentResourceManager componentResourceManager;
						this.BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
						base.ClientSize = new Size(505, 395);
						num = 26;
						continue;
					}
					case 89:
						this.cmdCancel.Text = "CANCEL";
						this.cmdCancel.UseVisualStyleBackColor = false;
						this.cmdLogin.BackColor = Color.FromArgb(255, 128, 0);
						num = 30;
						continue;
					case 90:
					{
						ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form7));
						this.cmdCancel = new Button();
						this.cmdLogin = new Button();
						this.txtPassword = new TextBox();
						num = 29;
						continue;
					}
					case 91:
						this.txtPassword.Location = new Point(212, 182);
						this.txtPassword.Margin = new Padding(4, 4, 4, 4);
						this.txtPassword.Name = "txtPassword";
						this.txtPassword.PasswordChar = '*';
						num = 31;
						continue;
					case 92:
						this.Label1.Size = new Size(241, 17);
						this.Label1.TabIndex = 28;
						this.Label1.Text = "Welcome to the Lecturer Login Menu";
						num = 18;
						continue;
					case 93:
						base.Controls.Add(this.txtUsername);
						base.Controls.Add(this.Label3);
						base.Controls.Add(this.Label2);
						base.Controls.Add(this.Label1);
						num = 20;
						continue;
					case 94:
						this.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
						base.Margin = new Padding(4, 4, 4, 4);
						base.Name = "Form7";
						num = 47;
						continue;
					case 95:
						this.cmdLogin.TabIndex = 33;
						this.cmdLogin.Text = "LOGIN";
						this.cmdLogin.UseVisualStyleBackColor = false;
						num = 17;
						continue;
					case 96:
						base.SuspendLayout();
						this.cmdCancel.BackColor = Color.FromArgb(255, 128, 0);
						this.cmdCancel.Location = new Point(304, 319);
						num = 28;
						continue;
					case 97:
						this.Label2.TabIndex = 29;
						this.Label2.Text = "Username:";
						this.Label1.AutoSize = true;
						num = 41;
						continue;
					case 98:
					{
						RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form7.get_txtPassword()).MethodHandle;
						num = 40;
						continue;
					}
					case 99:
						this.Label1.BackColor = Color.FromArgb(255, 128, 0);
						for (;;)
						{
							int num4 = 27;
							for (;;)
							{
								switch (num4 ^ 80)
								{
								case 73:
									num4 = 31;
									continue;
								case 74:
									this.Label1.Location = new Point(111, 37);
									num4 = 25;
									continue;
								case 75:
									num4 = 26;
									continue;
								case 76:
								{
									RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form7.get_Label2()).MethodHandle;
									num4 = 28;
									continue;
								}
								case 77:
									this.Label1.Name = "Label1";
									num4 = 0;
									continue;
								case 78:
									num4 = 29;
									continue;
								case 79:
									this.Label1.Margin = new Padding(4, 0, 4, 0);
									num4 = 30;
									continue;
								case 80:
									num = 22;
									num4 = 1;
									continue;
								case 81:
									goto IL_73E;
								}
								break;
							}
						}
						IL_73E:
						continue;
					case 100:
						this.txtUsername.Margin = new Padding(4, 4, 4, 4);
						this.txtUsername.Name = "txtUsername";
						this.txtUsername.Size = new Size(213, 23);
						this.txtUsername.TabIndex = 31;
						num = 25;
						continue;
					case 101:
						goto IL_796;
					}
					break;
				}
			}
			IL_796:
			this.Text = "Form7";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0001AAE2 File Offset: 0x00018CE2
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0001AAF0 File Offset: 0x00018CF0
		internal virtual Button cmdCancel
		{
			[CompilerGenerated]
			get
			{
				return this._cmdCancel;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mqgfoefwabbyet);
				Button cmdCancel = this._cmdCancel;
				if (cmdCancel != null)
				{
					cmdCancel.Click -= value2;
				}
				this._cmdCancel = value;
				cmdCancel = this._cmdCancel;
				if (cmdCancel != null)
				{
					cmdCancel.Click += value2;
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0001AB5B File Offset: 0x00018D5B
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0001AB6C File Offset: 0x00018D6C
		internal virtual Button cmdLogin
		{
			[CompilerGenerated]
			get
			{
				return this._cmdLogin;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.mqgfoefwabbyes);
				Button cmdLogin = this._cmdLogin;
				if (cmdLogin != null)
				{
					cmdLogin.Click -= value2;
				}
				this._cmdLogin = value;
				cmdLogin = this._cmdLogin;
				if (cmdLogin != null)
				{
					cmdLogin.Click += value2;
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0001ABD7 File Offset: 0x00018DD7
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x0001ABE5 File Offset: 0x00018DE5
		internal virtual TextBox txtPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0001ABF2 File Offset: 0x00018DF2
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0001AC00 File Offset: 0x00018E00
		internal virtual TextBox txtUsername { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0001AC0D File Offset: 0x00018E0D
		// (set) Token: 0x060001DA RID: 474 RVA: 0x0001AC1B File Offset: 0x00018E1B
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0001AC28 File Offset: 0x00018E28
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0001AC36 File Offset: 0x00018E36
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0001AC43 File Offset: 0x00018E43
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0001AC51 File Offset: 0x00018E51
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060001DF RID: 479 RVA: 0x0001AC60 File Offset: 0x00018E60
		private void mqgfoefwabbyes(object cx, EventArgs cy)
		{
			string str;
			for (;;)
			{
				int num = Form7.mqgfoefwabbyeu(21);
				for (;;)
				{
					num ^= 85;
					switch (num + 91)
					{
					case 0:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form7.set_Label1(Label)).MethodHandle;
						num = -16;
						continue;
					}
					case 1:
						str = "";
						num = -14;
						continue;
					case 2:
						this.con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\Joey\\Documents\\College.mdb; Persist Security Info = False", "", "", -1);
						num = -4;
						continue;
					case 3:
						this.rs.Open("Select * from LecturersProfile where LecturerID = '" + this.txtUsername.Text + "'", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
						num = -1;
						continue;
					case 4:
						num = Form7.mqgfoefwabbyeu(31);
						continue;
					case 5:
						goto IL_AD;
					}
					break;
				}
			}
			IL_AD:
			try
			{
				str = Conversions.ToString(this.rs.Fields["FirstName"].Value);
			}
			catch (Exception ex)
			{
			}
			bool eof = this.rs.EOF;
			if (eof)
			{
				this.con.Close();
				for (;;)
				{
					int num2 = 10;
					for (;;)
					{
						switch (num2 ^ 90)
						{
						case 80:
							num2 = 12;
							continue;
						case 81:
							this.txtUsername.Text = "";
							num2 = 9;
							continue;
						case 82:
							this.txtUsername.Focus();
							num2 = 15;
							continue;
						case 83:
							num2 = 13;
							continue;
						case 84:
						{
							RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form7.get_Label3()).MethodHandle;
							num2 = 14;
							continue;
						}
						case 85:
							num2 = 3;
							continue;
						case 86:
							Interaction.MsgBox("Username Not Found. Please Try Again.", MsgBoxStyle.Exclamation, "Login Error");
							num2 = 11;
							continue;
						case 87:
							this.txtPassword.Text = "";
							num2 = 2;
							continue;
						case 88:
							num2 = 8;
							continue;
						case 89:
							goto IL_1D1;
						}
						break;
					}
				}
				IL_1D1:;
			}
			else
			{
				bool flag = Operators.ConditionalCompareObjectEqual(this.txtPassword.Text, this.rs.Fields["Password"].Value, false);
				if (flag)
				{
					this.con.Close();
					for (;;)
					{
						int num3 = 3;
						for (;;)
						{
							switch (num3 ^ 90)
							{
							case 81:
								yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxg.Show();
								num3 = 0;
								continue;
							case 82:
								Interaction.MsgBox("Welcome, " + str + "!", MsgBoxStyle.Information, "Access Granted");
								num3 = 14;
								continue;
							case 83:
								num3 = 11;
								continue;
							case 84:
								base.Hide();
								num3 = 9;
								continue;
							case 85:
								yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxg.txtID.Enabled = false;
								num3 = 12;
								continue;
							case 86:
								num3 = 13;
								continue;
							case 87:
								num3 = 1;
								continue;
							case 88:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form7.get_Label1()).MethodHandle;
								num3 = 2;
								continue;
							}
							case 89:
								num3 = 8;
								continue;
							case 90:
								num3 = 15;
								continue;
							case 91:
								goto IL_301;
							}
							break;
						}
					}
					IL_301:;
				}
				else
				{
					bool flag2 = Operators.ConditionalCompareObjectNotEqual(this.txtPassword.Text, this.rs.Fields["Password"].Value, false);
					if (flag2)
					{
						this.con.Close();
						for (;;)
						{
							int num4 = 27;
							for (;;)
							{
								switch (num4 ^ 84)
								{
								case 79:
									num4 = 7;
									continue;
								case 80:
									this.txtPassword.Text = "";
									num4 = 6;
									continue;
								case 81:
								{
									RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form7.Dispose(bool)).MethodHandle;
									num4 = 5;
									continue;
								}
								case 82:
									num4 = 0;
									continue;
								case 83:
									Interaction.MsgBox("Incorrect Password. Please Try Again.", MsgBoxStyle.Exclamation, "Login Error");
									num4 = 4;
									continue;
								case 84:
									this.txtPassword.Focus();
									num4 = 1;
									continue;
								case 85:
									goto IL_419;
								}
								break;
							}
						}
						IL_419:;
					}
				}
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0001B098 File Offset: 0x00019298
		private void mqgfoefwabbyet(object cz, EventArgs da)
		{
			for (;;)
			{
				IL_DE:
				int num = 11;
				int num2 = 13;
				for (;;)
				{
					num2 ^= 82;
					for (;;)
					{
						IL_44:
						int num3 = 1;
						int num4 = 12;
						for (;;)
						{
							switch (num4 ^ 84)
							{
							case 85:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form7.get_Label2()).MethodHandle;
								num4 = 1;
								continue;
							}
							case 86:
								goto IL_44;
							case 87:
								switch (num3)
								{
								case 87:
									break;
								case 88:
									switch (num2)
									{
									case 92:
										switch (num)
										{
										case 82:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelwz.Show();
											num = 4;
											goto IL_0B;
										case 83:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form7.get_cmdCancel()).MethodHandle;
											num = 1;
											goto IL_0B;
										}
										case 84:
											num = 5;
											goto IL_0B;
										case 85:
											num = 0;
											goto IL_0B;
										case 86:
											num = 9;
											goto IL_0B;
										case 87:
											this.txtPassword.Text = "";
											num = 8;
											goto IL_0B;
										case 88:
											base.Hide();
											num = 7;
											goto IL_0B;
										case 89:
											this.txtUsername.Text = "";
											num = 6;
											goto IL_0B;
										case 90:
											num = 10;
											goto IL_0B;
										case 91:
											return;
										}
										goto Block_3;
									case 93:
										goto IL_DE;
									case 94:
										goto IL_E9;
									case 95:
										break;
									default:
										num3 = 14;
										goto IL_19;
									}
									IL_0B:
									num ^= 82;
									break;
								case 89:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form7.get_txtPassword()).MethodHandle;
									num3 = 0;
									goto IL_19;
								}
								case 90:
									goto IL_A0;
								default:
									num4 = 2;
									continue;
								}
								num2 = 14;
								num3 = 3;
								goto IL_19;
							case 88:
								goto IL_19;
							}
							IL_32:
							num4 = 3;
							continue;
							IL_19:
							num3 ^= 89;
							goto IL_32;
						}
					}
					IL_A0:
					continue;
					Block_3:
					num2 = 15;
					continue;
					IL_E9:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form7.mqgfoefwabbyet(object, EventArgs)).MethodHandle;
					num2 = 12;
				}
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0001B258 File Offset: 0x00019458
		internal static int mqgfoefwabbyeu(int db)
		{
			switch (db - ~(-20))
			{
			case 0:
				return -406297487 - -713330565 ^ -307033082;
			case 2:
				return ~(-522826996 ^ -474389768) + 57616872;
			case 4:
				return -706284726 - -706284711;
			case 5:
				return ~1463594498 - -568198541 + 291489260 - -603906696;
			case 6:
				return ~(~(-183810475)) + 183810474;
			case 7:
				return ~(~-251141119) + 251141058;
			case 8:
				return (-378943675 ^ 378943663) >> 1;
			case 9:
				return -383569792 + 383569560 >> 2;
			case 10:
				return 74830390 + -74830400;
			case 12:
				return -(-170603397 + 170603400);
			case 13:
				return ~(-1195401132 + 567815326) - 627585877 >> 3;
			case 14:
				return -(-327855533 + 327855592);
			case 16:
				return ~62;
			}
			return (-951498784 ^ -427518844) + -567137125;
		}

		// Token: 0x040000D4 RID: 212
		private IContainer components;

		// Token: 0x040000DC RID: 220
		private Connection con;

		// Token: 0x040000DD RID: 221
		private Recordset rs;
	}
}
