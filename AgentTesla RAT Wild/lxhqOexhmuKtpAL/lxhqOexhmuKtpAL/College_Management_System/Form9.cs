using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using College_Management_System.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace College_Management_System
{
	// Token: 0x02000019 RID: 25
	[DesignerGenerated]
	public class Form9 : Form
	{
		// Token: 0x06000246 RID: 582 RVA: 0x00020578 File Offset: 0x0001E778
		public Form9()
		{
			for (;;)
			{
				IL_B1:
				int num = Form2.uwpnsrqhswlmjh(50);
				int num2 = 11;
				for (;;)
				{
					num2 ^= 92;
					for (;;)
					{
						IL_42:
						int num3 = 9;
						int num4 = -10;
						for (;;)
						{
							num4 ^= 89;
							switch (num4 + 84)
							{
							case 0:
								goto IL_42;
							case 1:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.set_cmdDisplay(Button)).MethodHandle;
								num4 = -12;
								continue;
							}
							case 2:
								switch (num3)
								{
								case 79:
									break;
								case 80:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.get_cmdPrevious()).MethodHandle;
									num3 = 8;
									goto IL_1F;
								}
								case 81:
									switch (num2)
									{
									case 84:
										goto IL_B1;
									case 85:
										switch (num + 82)
										{
										case 0:
											num = -31;
											goto IL_11;
										case 1:
											num = Form12.wsyoqrrjsoniul(56);
											goto IL_11;
										case 2:
											this.eiydpywoxrtbio();
											num = -6;
											goto IL_11;
										case 3:
											this.con = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000514-0000-0010-8000-00AA006D2EA4")));
											num = -26;
											goto IL_11;
										case 4:
											this.rs = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("00000535-0000-0010-8000-00AA006D2EA4")));
											num = -28;
											goto IL_11;
										case 5:
											base.Load += this.eiydpywoxrtbip;
											num = -5;
											goto IL_11;
										case 6:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.get_Label2()).MethodHandle;
											num = -32;
											goto IL_11;
										}
										case 7:
											return;
										}
										goto Block_3;
									case 86:
										goto IL_F1;
									case 87:
										break;
									default:
										num3 = 23;
										goto IL_1F;
									}
									IL_11:
									num ^= 84;
									break;
								case 82:
									goto IL_AC;
								default:
									num4 = -11;
									continue;
								}
								num2 = 9;
								num3 = 10;
								goto IL_1F;
							case 3:
								goto IL_1F;
							}
							IL_38:
							num4 = Form7.mqgfoefwabbyeu(32);
							continue;
							IL_1F:
							num3 ^= 88;
							goto IL_38;
						}
					}
					IL_AC:
					continue;
					Block_3:
					num2 = 8;
					continue;
					IL_F1:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.set_GroupBox1(GroupBox)).MethodHandle;
					num2 = 10;
				}
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0002075C File Offset: 0x0001E95C
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
						IL_10E:
						int num = Form7.mqgfoefwabbyeu(19);
						int num2 = -3;
						for (;;)
						{
							num2 ^= 86;
							for (;;)
							{
								IL_B5:
								int num3 = Form12.wsyoqrrjsoniul(58);
								int num4 = -28;
								for (;;)
								{
									num4 ^= 85;
									switch (num4 + 82)
									{
									case 0:
										switch (num3 + 91)
										{
										case 0:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.eiydpywoxrtbiu(object, EventArgs)).MethodHandle;
											num3 = Form7.mqgfoefwabbyeu(32);
											goto IL_4F;
										}
										case 1:
											switch (num2 + 88)
											{
											case 0:
												goto IL_10E;
											case 1:
												switch (num + 87)
												{
												case 0:
													num = -10;
													goto IL_3E;
												case 1:
													this.components.Dispose();
													num = -13;
													goto IL_3E;
												case 2:
												{
													RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.set_lblPassword(Label)).MethodHandle;
													num = -15;
													goto IL_3E;
												}
												case 3:
													goto IL_1AA;
												}
												goto Block_6;
											case 2:
												goto IL_148;
											case 3:
												break;
											default:
												num3 = -11;
												goto IL_4F;
											}
											IL_3E:
											num ^= 90;
											break;
										case 2:
											break;
										case 3:
											goto IL_109;
										default:
											num4 = -27;
											continue;
										}
										num2 = Form7.mqgfoefwabbyeu(25);
										num3 = -6;
										break;
									case 1:
									{
										RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.set_Label3(Label)).MethodHandle;
										num4 = Form2.uwpnsrqhswlmjh(44);
										continue;
									}
									case 2:
										goto IL_B5;
									case 3:
										break;
									default:
										IL_7A:
										num4 = Form2.uwpnsrqhswlmjh(34);
										continue;
									}
									IL_4F:
									num3 ^= 82;
									goto IL_7A;
								}
							}
							IL_109:
							continue;
							Block_6:
							num2 = -2;
							continue;
							IL_148:
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.get_cmdSearch()).MethodHandle;
							num2 = Form2.uwpnsrqhswlmjh(42);
						}
					}
					IL_1AA:;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00020940 File Offset: 0x0001EB40
		[DebuggerStepThrough]
		private void eiydpywoxrtbio()
		{
			for (;;)
			{
				int num = 15;
				for (;;)
				{
					num ^= 81;
					switch (num)
					{
					case 86:
						base.SuspendLayout();
						this.GroupBox3.Controls.Add(this.Label2);
						this.GroupBox3.Location = new Point(207, 18);
						this.GroupBox3.Name = "GroupBox3";
						this.GroupBox3.Size = new Size(397, 62);
						this.GroupBox3.TabIndex = 148;
						this.GroupBox3.TabStop = false;
						this.Label2.AutoSize = true;
						this.Label2.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular, GraphicsUnit.Point, 0);
						this.Label2.Location = new Point(22, 19);
						this.Label2.Name = "Label2";
						this.Label2.Size = new Size(350, 31);
						this.Label2.TabIndex = 122;
						this.Label2.Text = "STUDENT PROFILE PAGE";
						num = 11;
						continue;
					case 87:
						this.rbMale.Location = new Point(207, 244);
						this.rbMale.Name = "rbMale";
						this.rbMale.Size = new Size(56, 21);
						this.rbMale.TabIndex = 143;
						this.rbMale.TabStop = true;
						this.rbMale.Text = "Male";
						this.rbMale.UseVisualStyleBackColor = true;
						this.cmdAdd.BackColor = Color.BlueViolet;
						this.cmdAdd.ForeColor = Color.White;
						this.cmdAdd.Location = new Point(14, 22);
						this.cmdAdd.Name = "cmdAdd";
						this.cmdAdd.Size = new Size(97, 34);
						this.cmdAdd.TabIndex = 92;
						this.cmdAdd.Text = "ADD NEW";
						num = 61;
						continue;
					case 88:
						base.Controls.Add(this.lblPassword);
						for (;;)
						{
							int num2 = 3;
							for (;;)
							{
								switch (num2 ^ 89)
								{
								case 80:
									base.Controls.Add(this.DateTimePicker1);
									num2 = 0;
									continue;
								case 81:
									base.Controls.Add(this.txtFirstName);
									num2 = 14;
									continue;
								case 82:
									num = 50;
									num2 = 6;
									continue;
								case 83:
									base.Controls.Add(this.txtPhone);
									num2 = 8;
									continue;
								case 84:
									base.Controls.Add(this.rbMale);
									num2 = 5;
									continue;
								case 85:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.set_Label2(Label)).MethodHandle;
									num2 = 12;
									continue;
								}
								case 86:
									base.Controls.Add(this.cboProgram);
									num2 = 9;
									continue;
								case 87:
									base.Controls.Add(this.txtAdmNo);
									num2 = 2;
									continue;
								case 88:
									base.Controls.Add(this.rbFemale);
									num2 = 13;
									continue;
								case 89:
									base.Controls.Add(this.txtEmail);
									num2 = 10;
									continue;
								case 90:
									base.Controls.Add(this.GroupBox2);
									num2 = 1;
									continue;
								case 91:
									base.Controls.Add(this.Label9);
									num2 = 11;
									continue;
								case 92:
									base.Controls.Add(this.txtLastName);
									num2 = 7;
									continue;
								case 93:
									base.Controls.Add(this.PictureBox1);
									num2 = 15;
									continue;
								case 94:
									base.Controls.Add(this.cmdPhoto);
									num2 = 4;
									continue;
								case 95:
									goto IL_3F3;
								}
								break;
							}
						}
						IL_3F3:
						continue;
					case 89:
						this.txtFirstName.TabIndex = 134;
						this.cmdUpdate.BackColor = Color.BlueViolet;
						this.cmdUpdate.Location = new Point(227, 65);
						this.cmdUpdate.Name = "cmdUpdate";
						this.cmdUpdate.Size = new Size(98, 34);
						this.cmdUpdate.TabIndex = 32;
						this.cmdUpdate.Text = "UPDATE";
						this.cmdUpdate.UseVisualStyleBackColor = false;
						this.cmdBack.BackColor = Color.BlueViolet;
						this.cmdBack.ForeColor = Color.White;
						this.cmdBack.Location = new Point(331, 65);
						this.cmdBack.Name = "cmdBack";
						this.cmdBack.Size = new Size(101, 34);
						this.cmdBack.TabIndex = 84;
						num = 55;
						continue;
					case 90:
						this.txtPassword.Location = new Point(207, 384);
						this.txtPassword.Name = "txtPassword";
						this.txtPassword.Size = new Size(236, 23);
						this.txtPassword.TabIndex = 147;
						this.lblPassword.AutoSize = true;
						this.lblPassword.ForeColor = Color.White;
						this.lblPassword.Location = new Point(108, 387);
						this.lblPassword.Name = "lblPassword";
						this.lblPassword.Size = new Size(73, 17);
						this.lblPassword.TabIndex = 146;
						this.lblPassword.Text = "Password:";
						this.GroupBox2.Controls.Add(this.cmdNext);
						this.GroupBox2.Controls.Add(this.cmdPrevious);
						this.GroupBox2.Controls.Add(this.cmdFirst);
						num = 51;
						continue;
					case 91:
						this.cboProgram.Location = new Point(207, 274);
						for (;;)
						{
							int num3 = 3;
							for (;;)
							{
								switch (num3 ^ 88)
								{
								case 85:
									this.DateTimePicker1.TabIndex = 138;
									num3 = 58;
									continue;
								case 86:
									this.DateTimePicker1.Name = "DateTimePicker1";
									num3 = 57;
									continue;
								case 87:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.get_cmdSave()).MethodHandle;
									num3 = 15;
									continue;
								}
								case 88:
									this.txtPhone.Location = new Point(207, 312);
									num3 = 7;
									continue;
								case 89:
									this.txtEmail.Name = "txtEmail";
									num3 = 56;
									continue;
								case 90:
									this.txtEmail.Location = new Point(207, 348);
									num3 = 1;
									continue;
								case 91:
									this.cboProgram.Name = "cboProgram";
									num3 = 5;
									continue;
								case 92:
									this.cboProgram.TabIndex = 139;
									num3 = 6;
									continue;
								case 93:
									this.cboProgram.Size = new Size(236, 24);
									num3 = 4;
									continue;
								case 94:
									this.DateTimePicker1.Location = new Point(207, 212);
									num3 = 14;
									continue;
								case 95:
									num = 48;
									num3 = 60;
									continue;
								case 96:
									this.txtEmail.Size = new Size(236, 23);
									num3 = 59;
									continue;
								case 97:
									this.DateTimePicker1.Size = new Size(236, 23);
									num3 = 13;
									continue;
								case 98:
									this.DateTimePicker1.Value = new DateTime(2017, 4, 8, 0, 0, 0, 0);
									num3 = 2;
									continue;
								case 99:
									this.txtEmail.TabIndex = 137;
									num3 = 0;
									continue;
								case 100:
									goto IL_81B;
								}
								break;
							}
						}
						IL_81B:
						continue;
					case 92:
					{
						RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.set_cmdAdd(Button)).MethodHandle;
						num = 13;
						continue;
					}
					case 93:
						this.txtAdmNo = new TextBox();
						this.Label9 = new Label();
						this.Label8 = new Label();
						this.Label7 = new Label();
						this.Label6 = new Label();
						this.Label5 = new Label();
						this.Label4 = new Label();
						this.Label3 = new Label();
						this.Label1 = new Label();
						this.GroupBox1 = new GroupBox();
						this.GroupBox3.SuspendLayout();
						this.GroupBox2.SuspendLayout();
						((ISupportInitialize)this.PictureBox1).BeginInit();
						this.GroupBox1.SuspendLayout();
						num = 7;
						continue;
					case 94:
						this.GroupBox3 = new GroupBox();
						this.Label2 = new Label();
						this.txtPassword = new TextBox();
						this.lblPassword = new Label();
						this.GroupBox2 = new GroupBox();
						this.cmdNext = new Button();
						this.cmdPrevious = new Button();
						this.cmdFirst = new Button();
						this.cmdLast = new Button();
						this.OpenFileDialog1 = new OpenFileDialog();
						this.rbFemale = new RadioButton();
						this.cmdDelete = new Button();
						this.rbMale = new RadioButton();
						this.cmdAdd = new Button();
						num = 58;
						continue;
					case 95:
						this.rbFemale.TabIndex = 144;
						this.rbFemale.TabStop = true;
						this.rbFemale.Text = "Female";
						this.rbFemale.UseVisualStyleBackColor = true;
						this.cmdDelete.BackColor = Color.BlueViolet;
						this.cmdDelete.ForeColor = Color.White;
						this.cmdDelete.Location = new Point(14, 65);
						this.cmdDelete.Name = "cmdDelete";
						this.cmdDelete.Size = new Size(97, 34);
						this.cmdDelete.TabIndex = 94;
						this.cmdDelete.Text = "DELETE";
						this.cmdDelete.UseVisualStyleBackColor = false;
						this.rbMale.AutoSize = true;
						this.rbMale.ForeColor = Color.White;
						num = 6;
						continue;
					case 96:
						this.cmdPhoto.ForeColor = Color.White;
						this.cmdPhoto.Location = new Point(538, 254);
						this.cmdPhoto.Name = "cmdPhoto";
						this.cmdPhoto.Size = new Size(138, 31);
						this.cmdPhoto.TabIndex = 141;
						this.cmdPhoto.Text = "UPLOAD PHOTO";
						this.cmdPhoto.UseVisualStyleBackColor = false;
						this.PictureBox1.BackColor = Color.SteelBlue;
						this.PictureBox1.Location = new Point(502, 98);
						this.PictureBox1.Name = "PictureBox1";
						this.PictureBox1.Size = new Size(200, 150);
						this.PictureBox1.TabIndex = 140;
						this.PictureBox1.TabStop = false;
						this.cboProgram.FormattingEnabled = true;
						num = 10;
						continue;
					case 97:
						this.txtPhone.Name = "txtPhone";
						this.txtPhone.Size = new Size(236, 23);
						this.txtPhone.TabIndex = 136;
						this.cmdSave.BackColor = Color.BlueViolet;
						this.cmdSave.ForeColor = Color.White;
						this.cmdSave.Location = new Point(121, 22);
						this.cmdSave.Name = "cmdSave";
						this.cmdSave.Size = new Size(98, 34);
						this.cmdSave.TabIndex = 93;
						this.cmdSave.Text = "SAVE";
						this.cmdSave.UseVisualStyleBackColor = false;
						this.txtFirstName.Location = new Point(207, 136);
						this.txtFirstName.Name = "txtFirstName";
						this.txtFirstName.Size = new Size(236, 23);
						num = 8;
						continue;
					case 98:
						this.GroupBox2.Controls.Add(this.cmdLast);
						this.GroupBox2.ForeColor = Color.White;
						this.GroupBox2.Location = new Point(502, 424);
						this.GroupBox2.Name = "GroupBox2";
						this.GroupBox2.Size = new Size(259, 112);
						this.GroupBox2.TabIndex = 145;
						this.GroupBox2.TabStop = false;
						this.GroupBox2.Text = "Navigation";
						this.cmdNext.BackColor = Color.BlueViolet;
						this.cmdNext.Location = new Point(19, 65);
						this.cmdNext.Name = "cmdNext";
						this.cmdNext.Size = new Size(101, 34);
						this.cmdNext.TabIndex = 57;
						this.cmdNext.Text = "NEXT";
						num = 53;
						continue;
					case 99:
						base.Controls.Add(this.Label8);
						base.Controls.Add(this.Label7);
						base.Controls.Add(this.Label6);
						base.Controls.Add(this.Label5);
						base.Controls.Add(this.Label4);
						base.Controls.Add(this.Label3);
						base.Controls.Add(this.Label1);
						base.Controls.Add(this.GroupBox1);
						this.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
						base.Margin = new Padding(4, 4, 4, 4);
						base.Name = "Form9";
						this.Text = "Form9";
						this.GroupBox3.ResumeLayout(false);
						this.GroupBox3.PerformLayout();
						num = 62;
						continue;
					case 100:
						this.cmdNext.UseVisualStyleBackColor = false;
						this.cmdPrevious.BackColor = Color.BlueViolet;
						this.cmdPrevious.Location = new Point(141, 65);
						this.cmdPrevious.Name = "cmdPrevious";
						this.cmdPrevious.Size = new Size(101, 34);
						this.cmdPrevious.TabIndex = 55;
						this.cmdPrevious.Text = "PREVIOUS";
						this.cmdPrevious.UseVisualStyleBackColor = false;
						this.cmdFirst.BackColor = Color.BlueViolet;
						this.cmdFirst.Location = new Point(19, 25);
						this.cmdFirst.Name = "cmdFirst";
						this.cmdFirst.Size = new Size(101, 34);
						this.cmdFirst.TabIndex = 56;
						this.cmdFirst.Text = "FIRST";
						num = 52;
						continue;
					case 101:
						this.cmdFirst.UseVisualStyleBackColor = false;
						this.cmdLast.BackColor = Color.BlueViolet;
						this.cmdLast.Location = new Point(141, 25);
						this.cmdLast.Name = "cmdLast";
						this.cmdLast.Size = new Size(101, 34);
						this.cmdLast.TabIndex = 58;
						this.cmdLast.Text = "LAST";
						this.cmdLast.UseVisualStyleBackColor = false;
						this.OpenFileDialog1.FileName = "OpenFileDialog1";
						this.rbFemale.AutoSize = true;
						this.rbFemale.ForeColor = Color.White;
						this.rbFemale.Location = new Point(371, 244);
						this.rbFemale.Name = "rbFemale";
						this.rbFemale.Size = new Size(72, 21);
						num = 14;
						continue;
					case 102:
						this.cmdBack.Text = "BACK";
						this.cmdBack.UseVisualStyleBackColor = false;
						this.cmdDisplay.BackColor = Color.BlueViolet;
						this.cmdDisplay.Location = new Point(121, 65);
						this.cmdDisplay.Name = "cmdDisplay";
						this.cmdDisplay.Size = new Size(98, 34);
						this.cmdDisplay.TabIndex = 58;
						this.cmdDisplay.Text = "DISPLAY";
						this.cmdDisplay.UseVisualStyleBackColor = false;
						this.cmdSearch.BackColor = Color.BlueViolet;
						this.cmdSearch.ForeColor = Color.White;
						this.cmdSearch.Location = new Point(332, 22);
						this.cmdSearch.Name = "cmdSearch";
						this.cmdSearch.Size = new Size(98, 34);
						num = 63;
						continue;
					case 103:
						this.Label6.AutoSize = true;
						this.Label6.ForeColor = Color.White;
						this.Label6.Location = new Point(108, 244);
						this.Label6.Name = "Label6";
						this.Label6.Size = new Size(60, 17);
						this.Label6.TabIndex = 129;
						this.Label6.Text = "Gender:";
						this.Label5.AutoSize = true;
						this.Label5.ForeColor = Color.White;
						this.Label5.Location = new Point(108, 212);
						this.Label5.Name = "Label5";
						this.Label5.Size = new Size(91, 17);
						this.Label5.TabIndex = 128;
						this.Label5.Text = "Date of Birth:";
						num = 59;
						continue;
					case 104:
						this.GroupBox1.Controls.Add(this.cmdSearch);
						this.GroupBox1.ForeColor = Color.White;
						this.GroupBox1.Location = new Point(29, 424);
						this.GroupBox1.Name = "GroupBox1";
						this.GroupBox1.Size = new Size(444, 112);
						this.GroupBox1.TabIndex = 142;
						this.GroupBox1.TabStop = false;
						this.GroupBox1.Text = "Commands";
						base.AutoScaleDimensions = new SizeF(8f, 16f);
						base.AutoScaleMode = AutoScaleMode.Font;
						this.BackColor = Color.SteelBlue;
						base.ClientSize = new Size(790, 555);
						base.Controls.Add(this.GroupBox3);
						base.Controls.Add(this.txtPassword);
						num = 9;
						continue;
					case 105:
						this.Label1.AutoSize = true;
						for (;;)
						{
							int num4 = Form7.mqgfoefwabbyeu(25);
							for (;;)
							{
								num4 ^= 83;
								switch (num4 + 91)
								{
								case 0:
									this.GroupBox1.Controls.Add(this.cmdEdit);
									num4 = -3;
									continue;
								case 1:
									this.Label1.Text = "Adm No:";
									num4 = -7;
									continue;
								case 2:
									num = 57;
									num4 = -25;
									continue;
								case 3:
								{
									RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.set_Label3(Label)).MethodHandle;
									num4 = -5;
									continue;
								}
								case 4:
									this.Label1.Size = new Size(62, 17);
									num4 = -29;
									continue;
								case 5:
									this.GroupBox1.Controls.Add(this.cmdBack);
									num4 = -10;
									continue;
								case 6:
									this.GroupBox1.Controls.Add(this.cmdDelete);
									num4 = -31;
									continue;
								case 7:
									this.Label1.ForeColor = Color.White;
									num4 = Form6.sbdifomqugmuko(61);
									continue;
								case 8:
									this.Label1.Name = "Label1";
									num4 = -6;
									continue;
								case 9:
									this.GroupBox1.Controls.Add(this.cmdDisplay);
									num4 = -32;
									continue;
								case 10:
									this.GroupBox1.Controls.Add(this.cmdAdd);
									num4 = -12;
									continue;
								case 11:
									this.Label1.TabIndex = 125;
									num4 = -11;
									continue;
								case 12:
									this.Label1.Location = new Point(108, 98);
									num4 = -2;
									continue;
								case 13:
									this.GroupBox1.Controls.Add(this.cmdSave);
									num4 = -4;
									continue;
								case 14:
									this.GroupBox1.Controls.Add(this.cmdUpdate);
									num4 = -8;
									continue;
								case 15:
									goto IL_1588;
								}
								break;
							}
						}
						IL_1588:
						continue;
					case 106:
						this.Label4.AutoSize = true;
						this.Label4.ForeColor = Color.White;
						this.Label4.Location = new Point(108, 174);
						this.Label4.Name = "Label4";
						this.Label4.Size = new Size(80, 17);
						this.Label4.TabIndex = 127;
						this.Label4.Text = "Last Name:";
						this.Label3.AutoSize = true;
						this.Label3.ForeColor = Color.White;
						this.Label3.Location = new Point(108, 136);
						this.Label3.Name = "Label3";
						this.Label3.Size = new Size(80, 17);
						this.Label3.TabIndex = 126;
						this.Label3.Text = "First Name:";
						num = 56;
						continue;
					case 107:
						this.txtLastName = new TextBox();
						this.cmdEdit = new Button();
						this.cmdPhoto = new Button();
						this.PictureBox1 = new PictureBox();
						this.cboProgram = new ComboBox();
						this.DateTimePicker1 = new DateTimePicker();
						this.txtEmail = new TextBox();
						this.txtPhone = new TextBox();
						this.cmdSave = new Button();
						this.txtFirstName = new TextBox();
						this.cmdUpdate = new Button();
						this.cmdBack = new Button();
						this.cmdDisplay = new Button();
						this.cmdSearch = new Button();
						num = 12;
						continue;
					case 108:
						this.cmdAdd.UseVisualStyleBackColor = false;
						this.txtLastName.Location = new Point(207, 174);
						this.txtLastName.Name = "txtLastName";
						this.txtLastName.Size = new Size(236, 23);
						this.txtLastName.TabIndex = 135;
						this.cmdEdit.BackColor = Color.BlueViolet;
						this.cmdEdit.ForeColor = Color.White;
						this.cmdEdit.Location = new Point(225, 22);
						this.cmdEdit.Name = "cmdEdit";
						this.cmdEdit.Size = new Size(101, 34);
						this.cmdEdit.TabIndex = 95;
						this.cmdEdit.Text = "EDIT";
						this.cmdEdit.UseVisualStyleBackColor = false;
						this.cmdPhoto.BackColor = Color.BlueViolet;
						num = 49;
						continue;
					case 109:
						this.Label8.AutoSize = true;
						this.Label8.ForeColor = Color.White;
						this.Label8.Location = new Point(108, 315);
						this.Label8.Name = "Label8";
						this.Label8.Size = new Size(75, 17);
						this.Label8.TabIndex = 131;
						this.Label8.Text = "Phone No:";
						this.Label7.AutoSize = true;
						this.Label7.ForeColor = Color.White;
						this.Label7.Location = new Point(108, 277);
						this.Label7.Name = "Label7";
						this.Label7.Size = new Size(66, 17);
						this.Label7.TabIndex = 130;
						this.Label7.Text = "Program:";
						num = 54;
						continue;
					case 110:
						this.cmdSearch.TabIndex = 95;
						this.cmdSearch.Text = "SEARCH";
						this.cmdSearch.UseVisualStyleBackColor = false;
						this.txtAdmNo.Location = new Point(207, 98);
						this.txtAdmNo.Name = "txtAdmNo";
						this.txtAdmNo.Size = new Size(236, 23);
						this.txtAdmNo.TabIndex = 133;
						this.Label9.AutoSize = true;
						this.Label9.ForeColor = Color.White;
						this.Label9.Location = new Point(108, 351);
						this.Label9.Name = "Label9";
						this.Label9.Size = new Size(46, 17);
						this.Label9.TabIndex = 132;
						this.Label9.Text = "Email:";
						num = 60;
						continue;
					case 111:
						goto IL_1A4A;
					}
					break;
				}
			}
			IL_1A4A:
			this.GroupBox2.ResumeLayout(false);
			((ISupportInitialize)this.PictureBox1).EndInit();
			this.GroupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00022460 File Offset: 0x00020660
		// (set) Token: 0x0600024A RID: 586 RVA: 0x0002246E File Offset: 0x0002066E
		internal virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0002247B File Offset: 0x0002067B
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00022489 File Offset: 0x00020689
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00022496 File Offset: 0x00020696
		// (set) Token: 0x0600024E RID: 590 RVA: 0x000224A4 File Offset: 0x000206A4
		internal virtual TextBox txtPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600024F RID: 591 RVA: 0x000224B1 File Offset: 0x000206B1
		// (set) Token: 0x06000250 RID: 592 RVA: 0x000224BF File Offset: 0x000206BF
		internal virtual Label lblPassword { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000224CC File Offset: 0x000206CC
		// (set) Token: 0x06000252 RID: 594 RVA: 0x000224DA File Offset: 0x000206DA
		internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000253 RID: 595 RVA: 0x000224E7 File Offset: 0x000206E7
		// (set) Token: 0x06000254 RID: 596 RVA: 0x000224F8 File Offset: 0x000206F8
		internal virtual Button cmdNext
		{
			[CompilerGenerated]
			get
			{
				return this._cmdNext;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.eiydpywoxrtbiv);
				Button cmdNext = this._cmdNext;
				if (cmdNext != null)
				{
					cmdNext.Click -= value2;
				}
				this._cmdNext = value;
				cmdNext = this._cmdNext;
				if (cmdNext != null)
				{
					cmdNext.Click += value2;
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00022563 File Offset: 0x00020763
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00022574 File Offset: 0x00020774
		internal virtual Button cmdPrevious
		{
			[CompilerGenerated]
			get
			{
				return this._cmdPrevious;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.eiydpywoxrtbiw);
				Button cmdPrevious = this._cmdPrevious;
				if (cmdPrevious != null)
				{
					cmdPrevious.Click -= value2;
				}
				this._cmdPrevious = value;
				cmdPrevious = this._cmdPrevious;
				if (cmdPrevious != null)
				{
					cmdPrevious.Click += value2;
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000225DF File Offset: 0x000207DF
		// (set) Token: 0x06000258 RID: 600 RVA: 0x000225F0 File Offset: 0x000207F0
		internal virtual Button cmdFirst
		{
			[CompilerGenerated]
			get
			{
				return this._cmdFirst;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.eiydpywoxrtbit);
				Button cmdFirst = this._cmdFirst;
				if (cmdFirst != null)
				{
					cmdFirst.Click -= value2;
				}
				this._cmdFirst = value;
				cmdFirst = this._cmdFirst;
				if (cmdFirst != null)
				{
					cmdFirst.Click += value2;
				}
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0002265B File Offset: 0x0002085B
		// (set) Token: 0x0600025A RID: 602 RVA: 0x0002266C File Offset: 0x0002086C
		internal virtual Button cmdLast
		{
			[CompilerGenerated]
			get
			{
				return this._cmdLast;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.eiydpywoxrtbiu);
				Button cmdLast = this._cmdLast;
				if (cmdLast != null)
				{
					cmdLast.Click -= value2;
				}
				this._cmdLast = value;
				cmdLast = this._cmdLast;
				if (cmdLast != null)
				{
					cmdLast.Click += value2;
				}
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600025B RID: 603 RVA: 0x000226D7 File Offset: 0x000208D7
		// (set) Token: 0x0600025C RID: 604 RVA: 0x000226E5 File Offset: 0x000208E5
		internal virtual OpenFileDialog OpenFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600025D RID: 605 RVA: 0x000226F2 File Offset: 0x000208F2
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00022700 File Offset: 0x00020900
		internal virtual RadioButton rbFemale { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0002270D File Offset: 0x0002090D
		// (set) Token: 0x06000260 RID: 608 RVA: 0x0002271C File Offset: 0x0002091C
		internal virtual Button cmdDelete
		{
			[CompilerGenerated]
			get
			{
				return this._cmdDelete;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.eiydpywoxrtbix);
				Button cmdDelete = this._cmdDelete;
				if (cmdDelete != null)
				{
					cmdDelete.Click -= value2;
				}
				this._cmdDelete = value;
				cmdDelete = this._cmdDelete;
				if (cmdDelete != null)
				{
					cmdDelete.Click += value2;
				}
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00022787 File Offset: 0x00020987
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00022795 File Offset: 0x00020995
		internal virtual RadioButton rbMale { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000263 RID: 611 RVA: 0x000227A2 File Offset: 0x000209A2
		// (set) Token: 0x06000264 RID: 612 RVA: 0x000227B0 File Offset: 0x000209B0
		internal virtual Button cmdAdd
		{
			[CompilerGenerated]
			get
			{
				return this._cmdAdd;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.eiydpywoxrtbir);
				Button cmdAdd = this._cmdAdd;
				if (cmdAdd != null)
				{
					cmdAdd.Click -= value2;
				}
				this._cmdAdd = value;
				cmdAdd = this._cmdAdd;
				if (cmdAdd != null)
				{
					cmdAdd.Click += value2;
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0002281B File Offset: 0x00020A1B
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00022829 File Offset: 0x00020A29
		internal virtual TextBox txtLastName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00022836 File Offset: 0x00020A36
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00022844 File Offset: 0x00020A44
		internal virtual Button cmdEdit
		{
			[CompilerGenerated]
			get
			{
				return this._cmdEdit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.eiydpywoxrtbjc);
				Button cmdEdit = this._cmdEdit;
				if (cmdEdit != null)
				{
					cmdEdit.Click -= value2;
				}
				this._cmdEdit = value;
				cmdEdit = this._cmdEdit;
				if (cmdEdit != null)
				{
					cmdEdit.Click += value2;
				}
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000228AF File Offset: 0x00020AAF
		// (set) Token: 0x0600026A RID: 618 RVA: 0x000228C0 File Offset: 0x00020AC0
		internal virtual Button cmdPhoto
		{
			[CompilerGenerated]
			get
			{
				return this._cmdPhoto;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.eiydpywoxrtbiq);
				Button cmdPhoto = this._cmdPhoto;
				if (cmdPhoto != null)
				{
					cmdPhoto.Click -= value2;
				}
				this._cmdPhoto = value;
				cmdPhoto = this._cmdPhoto;
				if (cmdPhoto != null)
				{
					cmdPhoto.Click += value2;
				}
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0002292B File Offset: 0x00020B2B
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00022939 File Offset: 0x00020B39
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00022946 File Offset: 0x00020B46
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00022954 File Offset: 0x00020B54
		internal virtual ComboBox cboProgram { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00022961 File Offset: 0x00020B61
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0002296F File Offset: 0x00020B6F
		internal virtual DateTimePicker DateTimePicker1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0002297C File Offset: 0x00020B7C
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0002298A File Offset: 0x00020B8A
		internal virtual TextBox txtEmail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00022997 File Offset: 0x00020B97
		// (set) Token: 0x06000274 RID: 628 RVA: 0x000229A5 File Offset: 0x00020BA5
		internal virtual TextBox txtPhone { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000275 RID: 629 RVA: 0x000229B2 File Offset: 0x00020BB2
		// (set) Token: 0x06000276 RID: 630 RVA: 0x000229C0 File Offset: 0x00020BC0
		internal virtual Button cmdSave
		{
			[CompilerGenerated]
			get
			{
				return this._cmdSave;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.eiydpywoxrtbis);
				Button cmdSave = this._cmdSave;
				if (cmdSave != null)
				{
					cmdSave.Click -= value2;
				}
				this._cmdSave = value;
				cmdSave = this._cmdSave;
				if (cmdSave != null)
				{
					cmdSave.Click += value2;
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00022A2B File Offset: 0x00020C2B
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00022A39 File Offset: 0x00020C39
		internal virtual TextBox txtFirstName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00022A46 File Offset: 0x00020C46
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00022A54 File Offset: 0x00020C54
		internal virtual Button cmdUpdate
		{
			[CompilerGenerated]
			get
			{
				return this._cmdUpdate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.eiydpywoxrtbiy);
				Button cmdUpdate = this._cmdUpdate;
				if (cmdUpdate != null)
				{
					cmdUpdate.Click -= value2;
				}
				this._cmdUpdate = value;
				cmdUpdate = this._cmdUpdate;
				if (cmdUpdate != null)
				{
					cmdUpdate.Click += value2;
				}
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00022ABF File Offset: 0x00020CBF
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00022AD0 File Offset: 0x00020CD0
		internal virtual Button cmdBack
		{
			[CompilerGenerated]
			get
			{
				return this._cmdBack;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.eiydpywoxrtbjb);
				Button cmdBack = this._cmdBack;
				if (cmdBack != null)
				{
					cmdBack.Click -= value2;
				}
				this._cmdBack = value;
				cmdBack = this._cmdBack;
				if (cmdBack != null)
				{
					cmdBack.Click += value2;
				}
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00022B3B File Offset: 0x00020D3B
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00022B4C File Offset: 0x00020D4C
		internal virtual Button cmdDisplay
		{
			[CompilerGenerated]
			get
			{
				return this._cmdDisplay;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.eiydpywoxrtbiz);
				Button cmdDisplay = this._cmdDisplay;
				if (cmdDisplay != null)
				{
					cmdDisplay.Click -= value2;
				}
				this._cmdDisplay = value;
				cmdDisplay = this._cmdDisplay;
				if (cmdDisplay != null)
				{
					cmdDisplay.Click += value2;
				}
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00022BB7 File Offset: 0x00020DB7
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00022BC8 File Offset: 0x00020DC8
		internal virtual Button cmdSearch
		{
			[CompilerGenerated]
			get
			{
				return this._cmdSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.eiydpywoxrtbja);
				Button cmdSearch = this._cmdSearch;
				if (cmdSearch != null)
				{
					cmdSearch.Click -= value2;
				}
				this._cmdSearch = value;
				cmdSearch = this._cmdSearch;
				if (cmdSearch != null)
				{
					cmdSearch.Click += value2;
				}
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00022C33 File Offset: 0x00020E33
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00022C41 File Offset: 0x00020E41
		internal virtual TextBox txtAdmNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00022C4E File Offset: 0x00020E4E
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00022C5C File Offset: 0x00020E5C
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00022C69 File Offset: 0x00020E69
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00022C77 File Offset: 0x00020E77
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00022C84 File Offset: 0x00020E84
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00022C92 File Offset: 0x00020E92
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00022C9F File Offset: 0x00020E9F
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00022CAD File Offset: 0x00020EAD
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00022CBA File Offset: 0x00020EBA
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00022CC8 File Offset: 0x00020EC8
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00022CD5 File Offset: 0x00020ED5
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00022CE3 File Offset: 0x00020EE3
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00022CF0 File Offset: 0x00020EF0
		// (set) Token: 0x06000290 RID: 656 RVA: 0x00022CFE File Offset: 0x00020EFE
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00022D0B File Offset: 0x00020F0B
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00022D19 File Offset: 0x00020F19
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00022D26 File Offset: 0x00020F26
		// (set) Token: 0x06000294 RID: 660 RVA: 0x00022D34 File Offset: 0x00020F34
		internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000295 RID: 661 RVA: 0x00022D44 File Offset: 0x00020F44
		private void eiydpywoxrtbip(object eg, EventArgs eh)
		{
			for (;;)
			{
				IL_10A:
				int num = 59;
				int num2 = -12;
				for (;;)
				{
					num2 ^= 90;
					for (;;)
					{
						IL_3A:
						int num3 = Form12.wsyoqrrjsoniul(58);
						int num4 = 11;
						for (;;)
						{
							switch (num4 ^ 86)
							{
							case 90:
								goto IL_3A;
							case 91:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.get_cmdNext()).MethodHandle;
								num4 = 13;
								continue;
							}
							case 92:
								switch (num3 + 88)
								{
								case 0:
									switch (num2 + 85)
									{
									case 0:
										switch (num)
										{
										case 89:
											this.cboProgram.Items.Add("Electrical Engineering");
											num = 1;
											goto IL_0B;
										case 90:
											this.cboProgram.Items.Add("Communication");
											num = 7;
											goto IL_0B;
										case 91:
											num = 6;
											goto IL_0B;
										case 92:
											this.cboProgram.Items.Add("International Relations");
											num = 5;
											goto IL_0B;
										case 93:
											this.rs.Open("Select * from StudentsProfile", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
											num = 58;
											goto IL_0B;
										case 94:
											this.cboProgram.Items.Add("Economics");
											num = 4;
											goto IL_0B;
										case 95:
											this.con.Open("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\Joey\\Documents\\College.mdb; Persist Security Info = False", "", "", -1);
											num = 0;
											goto IL_0B;
										case 96:
											this.cboProgram.Items.Add("Applied Computer Science");
											num = 2;
											goto IL_0B;
										case 97:
											num = 56;
											goto IL_0B;
										case 98:
											num = 62;
											goto IL_0B;
										case 99:
											this.display();
											num = 57;
											goto IL_0B;
										case 100:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.get_rbFemale()).MethodHandle;
											num = 63;
											goto IL_0B;
										}
										case 101:
											return;
										}
										goto Block_3;
									case 1:
										goto IL_10A;
									case 2:
										goto IL_115;
									case 3:
										break;
									default:
										num3 = -10;
										goto IL_1C;
									}
									IL_0B:
									num ^= 91;
									break;
								case 1:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.set_cmdAdd(Button)).MethodHandle;
									num3 = -11;
									goto IL_1C;
								}
								case 2:
									break;
								case 3:
									goto IL_BB;
								default:
									num4 = 12;
									continue;
								}
								num2 = Form7.mqgfoefwabbyeu(23);
								num3 = Form7.mqgfoefwabbyeu(32);
								goto IL_1C;
							case 93:
								goto IL_1C;
							}
							IL_35:
							num4 = 10;
							continue;
							IL_1C:
							num3 ^= 92;
							goto IL_35;
						}
					}
					IL_BB:
					continue;
					Block_3:
					num2 = Form7.mqgfoefwabbyeu(29);
					continue;
					IL_115:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.eiydpywoxrtbiw(object, EventArgs)).MethodHandle;
					num2 = -9;
				}
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00022FB8 File Offset: 0x000211B8
		private void eiydpywoxrtbiq(object ei, EventArgs ej)
		{
			for (;;)
			{
				IL_B4:
				int num = 15;
				int num2 = -3;
				for (;;)
				{
					num2 ^= 80;
					for (;;)
					{
						IL_39:
						int num3 = 21;
						int num4 = 3;
						for (;;)
						{
							switch (num4 ^ 90)
							{
							case 86:
								goto IL_39;
							case 87:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.set_txtEmail(TextBox)).MethodHandle;
								num4 = 13;
								continue;
							}
							case 88:
								switch (num3)
								{
								case 90:
									switch (num2 + 86)
									{
									case 0:
										goto IL_B4;
									case 1:
										switch (num)
										{
										case 90:
											this.OpenFileDialog1.Filter = "Jpeg | *.jpg";
											num = 10;
											goto IL_0B;
										case 91:
											num = 12;
											goto IL_0B;
										case 92:
											this.PictureBox1.Image = Image.FromFile(this.str);
											num = 49;
											goto IL_0B;
										case 93:
											this.str = this.OpenFileDialog1.FileName;
											num = 13;
											goto IL_0B;
										case 94:
											this.OpenFileDialog1.ShowDialog();
											num = 11;
											goto IL_0B;
										case 95:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.get_rbMale()).MethodHandle;
											num = 14;
											goto IL_0B;
										}
										case 96:
											num = 48;
											goto IL_0B;
										case 97:
											return;
										}
										goto Block_3;
									case 2:
										goto IL_F0;
									case 3:
										break;
									default:
										num3 = 19;
										goto IL_1C;
									}
									IL_0B:
									num ^= 81;
									break;
								case 91:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.get_cmdPhoto()).MethodHandle;
									num3 = 20;
									goto IL_1C;
								}
								case 92:
									break;
								case 93:
									goto IL_AF;
								default:
									num4 = 12;
									continue;
								}
								num2 = Form2.uwpnsrqhswlmjh(34);
								num3 = 18;
								goto IL_1C;
							case 89:
								goto IL_1C;
							}
							IL_35:
							num4 = 2;
							continue;
							IL_1C:
							num3 ^= 79;
							goto IL_35;
						}
					}
					IL_AF:
					continue;
					Block_3:
					num2 = -6;
					continue;
					IL_F0:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.eiydpywoxrtbio()).MethodHandle;
					num2 = -4;
				}
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00023180 File Offset: 0x00021380
		private void eiydpywoxrtbir(object ek, EventArgs el)
		{
			for (;;)
			{
				IL_A7:
				int num = Form2.uwpnsrqhswlmjh(42);
				int num2 = 14;
				for (;;)
				{
					num2 ^= 80;
					for (;;)
					{
						IL_39:
						int num3 = Form12.wsyoqrrjsoniul(41);
						int num4 = 8;
						for (;;)
						{
							switch (num4 ^ 81)
							{
							case 86:
								goto IL_39;
							case 87:
								switch (num3 + 79)
								{
								case 0:
									switch (num2)
									{
									case 91:
										goto IL_99;
									case 92:
										goto IL_A7;
									case 93:
										switch (num + 86)
										{
										case 0:
											num = -3;
											goto IL_0B;
										case 1:
											this.PictureBox1.BorderStyle = BorderStyle.FixedSingle;
											num = -29;
											goto IL_0B;
										case 2:
											this.rs.AddNew(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
											num = -6;
											goto IL_0B;
										case 3:
											this.clear();
											num = -31;
											goto IL_0B;
										case 4:
										{
											RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.eiydpywoxrtbiq(object, EventArgs)).MethodHandle;
											num = -2;
											goto IL_0B;
										}
										case 5:
											num = -27;
											goto IL_0B;
										case 6:
											this.lblPassword.Visible = true;
											num = -28;
											goto IL_0B;
										case 7:
											num = -5;
											goto IL_0B;
										case 8:
											this.txtPassword.Visible = true;
											num = -1;
											goto IL_0B;
										case 9:
											num = -32;
											goto IL_0B;
										case 10:
											num = -30;
											goto IL_0B;
										case 11:
											return;
										}
										goto Block_2;
									case 94:
										break;
									default:
										num3 = -22;
										goto IL_1C;
									}
									IL_0B:
									num ^= 80;
									break;
								case 1:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.get_cmdSearch()).MethodHandle;
									num3 = -21;
									goto IL_1C;
								}
								case 2:
									break;
								case 3:
									goto IL_94;
								default:
									num4 = 7;
									continue;
								}
								num2 = 13;
								num3 = -19;
								goto IL_1C;
							case 88:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.eiydpywoxrtbjc(object, EventArgs)).MethodHandle;
								num4 = 9;
								continue;
							}
							case 89:
								goto IL_1C;
							}
							IL_35:
							num4 = 6;
							continue;
							IL_1C:
							num3 ^= 89;
							goto IL_35;
						}
					}
					IL_94:
					continue;
					IL_99:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.set_GroupBox2(GroupBox)).MethodHandle;
					num2 = 11;
					continue;
					Block_2:
					num2 = 12;
				}
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00023380 File Offset: 0x00021580
		public void clear()
		{
			for (;;)
			{
				IL_B8:
				int num = Form8.nxfpeikhibypgs(81);
				int num2 = 12;
				for (;;)
				{
					num2 ^= 85;
					for (;;)
					{
						IL_5E:
						int num3 = Form2.uwpnsrqhswlmjh(34);
						int num4 = -9;
						for (;;)
						{
							num4 ^= 80;
							switch (num4 + 92)
							{
							case 0:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.display()).MethodHandle;
								num4 = Form12.wsyoqrrjsoniul(58);
								continue;
							}
							case 1:
								switch (num3 + 84)
								{
								case 0:
									break;
								case 1:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.set_Label3(Label)).MethodHandle;
									num3 = -8;
									goto IL_19;
								}
								case 2:
									switch (num2)
									{
									case 86:
										goto IL_AB;
									case 87:
										goto IL_B8;
									case 88:
										switch (num + 91)
										{
										case 0:
											this.txtEmail.Text = "";
											num = -4;
											goto IL_0B;
										case 1:
											num = -15;
											goto IL_0B;
										case 2:
											num = -29;
											goto IL_0B;
										case 3:
											num = -22;
											goto IL_0B;
										case 4:
											num = -24;
											goto IL_0B;
										case 5:
											this.DateTimePicker1.Value = DateTime.Today;
											num = -14;
											goto IL_0B;
										case 6:
											this.txtLastName.Text = "";
											num = -3;
											goto IL_0B;
										case 7:
											num = -16;
											goto IL_0B;
										case 8:
											num = -31;
											goto IL_0B;
										case 9:
											num = -12;
											goto IL_0B;
										case 10:
											this.txtPhone.Text = "";
											num = Form6.sbdifomqugmuko(64);
											goto IL_0B;
										case 11:
											this.txtPassword.Text = "";
											num = -30;
											goto IL_0B;
										case 12:
											this.rbFemale.Checked = false;
											num = -19;
											goto IL_0B;
										case 13:
											num = -21;
											goto IL_0B;
										case 14:
											this.rbMale.Checked = false;
											num = -13;
											goto IL_0B;
										case 15:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.reload()).MethodHandle;
											num = -17;
											goto IL_0B;
										}
										case 16:
											this.txtAdmNo.Text = "";
											num = -10;
											goto IL_0B;
										case 17:
											num = -32;
											goto IL_0B;
										case 18:
											num = -2;
											goto IL_0B;
										case 19:
											this.PictureBox1.Image = null;
											num = -23;
											goto IL_0B;
										case 20:
											num = -25;
											goto IL_0B;
										case 21:
											this.txtFirstName.Text = "";
											num = -9;
											goto IL_0B;
										case 22:
											this.cboProgram.Text = "";
											num = -11;
											goto IL_0B;
										case 23:
											return;
										}
										goto Block_2;
									case 89:
										break;
									default:
										num3 = -7;
										goto IL_19;
									}
									IL_0B:
									num ^= 91;
									break;
								case 3:
									goto IL_A6;
								default:
									num4 = -10;
									continue;
								}
								num2 = 13;
								num3 = Form2.uwpnsrqhswlmjh(44);
								goto IL_19;
							case 2:
								goto IL_5E;
							case 3:
								goto IL_19;
							}
							IL_32:
							num4 = Form7.mqgfoefwabbyeu(27);
							continue;
							IL_19:
							num3 ^= 85;
							goto IL_32;
						}
					}
					IL_A6:
					continue;
					IL_AB:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.set_txtPassword(TextBox)).MethodHandle;
					num2 = 3;
					continue;
					Block_2:
					num2 = 2;
				}
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00023684 File Offset: 0x00021884
		public void display()
		{
			for (;;)
			{
				IL_65:
				int num = Form2.uwpnsrqhswlmjh(34);
				int num2 = 5;
				for (;;)
				{
					num2 ^= 88;
					for (;;)
					{
						int num3 = 11;
						for (;;)
						{
							switch (num3 ^ 92)
							{
							case 87:
								switch (num2)
								{
								case 90:
									goto IL_5A;
								case 91:
									goto IL_65;
								case 92:
									switch (num + 84)
									{
									case 0:
										this.txtAdmNo.Text = Conversions.ToString(this.rs.Fields["AdmNo"].Value);
										num = -7;
										goto IL_08;
									case 1:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.eiydpywoxrtbiu(object, EventArgs)).MethodHandle;
										num = Form2.uwpnsrqhswlmjh(44);
										goto IL_08;
									}
									case 2:
										num = -27;
										goto IL_08;
									case 3:
										this.txtLastName.Text = Conversions.ToString(this.rs.Fields["LastName"].Value);
										num = -28;
										goto IL_08;
									case 4:
										this.DateTimePicker1.Value = Conversions.ToDate(this.rs.Fields["DOB"].Value);
										num = -26;
										goto IL_08;
									case 5:
										num = -31;
										goto IL_08;
									case 6:
										this.txtFirstName.Text = Conversions.ToString(this.rs.Fields["FirstName"].Value);
										num = -29;
										goto IL_08;
									case 7:
										num = -25;
										goto IL_08;
									case 8:
										num = -8;
										goto IL_08;
									case 9:
									{
										bool flag;
										if (flag)
										{
											num = -32;
											goto IL_08;
										}
										goto IL_1F9;
									}
									case 10:
									{
										bool flag = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Gender"].Value, this.rbMale.Text, false);
										num = -30;
										goto IL_08;
									}
									case 11:
										goto IL_1F6;
									}
									goto Block_1;
								case 93:
									break;
								default:
									num3 = 5;
									continue;
								}
								IL_08:
								num ^= 87;
								goto IL_50;
							case 88:
							{
								RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.set_cmdFirst(Button)).MethodHandle;
								num3 = 4;
								continue;
							}
							case 89:
								goto IL_50;
							case 90:
								goto IL_58;
							}
							break;
							IL_50:
							num2 = 4;
							num3 = 6;
						}
					}
					IL_58:
					continue;
					IL_5A:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.get_PictureBox1()).MethodHandle;
					num2 = 2;
					continue;
					Block_1:
					num2 = 3;
				}
			}
			IL_1F6:
			bool flag2 = false;
			goto IL_1FC;
			IL_1F9:
			flag2 = true;
			IL_1FC:
			if (!flag2)
			{
				this.rbMale.Checked = true;
			}
			else
			{
				bool flag3 = Operators.ConditionalCompareObjectEqual(this.rs.Fields["Gender"].Value, this.rbFemale.Text, false);
				if (flag3)
				{
					this.rbFemale.Checked = true;
				}
			}
			this.cboProgram.Text = Conversions.ToString(this.rs.Fields["Program"].Value);
			for (;;)
			{
				int num4 = Form6.sbdifomqugmuko(64);
				for (;;)
				{
					num4 ^= 89;
					switch (num4 + 84)
					{
					case 0:
						this.lblPassword.Visible = false;
						num4 = -19;
						continue;
					case 1:
						this.txtPhone.Text = Conversions.ToString(this.rs.Fields["PhoneNo"].Value);
						num4 = -24;
						continue;
					case 2:
						this.txtPassword.Text = Conversions.ToString(this.rs.Fields["Password"].Value);
						num4 = -21;
						continue;
					case 3:
						this.txtPassword.Visible = false;
						num4 = -31;
						continue;
					case 4:
						this.PictureBox1.Image = Image.FromFile(Conversions.ToString(this.rs.Fields["Photo"].Value));
						num4 = -17;
						continue;
					case 5:
						num4 = -18;
						continue;
					case 6:
						num4 = -11;
						continue;
					case 7:
						num4 = -23;
						continue;
					case 8:
						num4 = -10;
						continue;
					case 9:
						num4 = -12;
						continue;
					case 10:
						num4 = Form7.mqgfoefwabbyeu(32);
						continue;
					case 11:
						this.txtEmail.Text = Conversions.ToString(this.rs.Fields["Email"].Value);
						num4 = -22;
						continue;
					case 12:
						num4 = -29;
						continue;
					case 13:
					{
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.get_txtAdmNo()).MethodHandle;
						num4 = -32;
						continue;
					}
					case 14:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00023AF4 File Offset: 0x00021CF4
		public void refreshData()
		{
			for (;;)
			{
				IL_9D:
				int num = 12;
				int num2 = -7;
				for (;;)
				{
					num2 ^= 83;
					for (;;)
					{
						int num3 = Form2.uwpnsrqhswlmjh(42);
						for (;;)
						{
							num3 ^= 84;
							switch (num3 + 89)
							{
							case 0:
								goto IL_38;
							case 1:
								switch (num2 + 89)
								{
								case 0:
									switch (num)
									{
									case 89:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.eiydpywoxrtbip(object, EventArgs)).MethodHandle;
										num = 15;
										goto IL_0B;
									}
									case 90:
										this.rs.Close();
										num = 11;
										goto IL_0B;
									case 91:
										num = 9;
										goto IL_0B;
									case 92:
										this.rs.Open("Select * from StudentsProfile", this.con, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockPessimistic, -1);
										num = 13;
										goto IL_0B;
									case 93:
										num = 10;
										goto IL_0B;
									case 94:
									{
										bool flag;
										if (flag)
										{
											num = 54;
											goto IL_0B;
										}
										goto IL_133;
									}
									case 95:
									{
										bool flag = !this.rs.EOF;
										num = 8;
										goto IL_0B;
									}
									case 96:
										goto IL_130;
									}
									goto Block_1;
								case 1:
									goto IL_9D;
								case 2:
									goto IL_A8;
								case 3:
									break;
								default:
									num3 = Form7.mqgfoefwabbyeu(21);
									continue;
								}
								IL_0B:
								num ^= 86;
								goto IL_38;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.get_cmdAdd()).MethodHandle;
								num3 = -3;
								continue;
							}
							case 3:
								goto IL_6A;
							}
							break;
							IL_38:
							num2 = Form12.wsyoqrrjsoniul(58);
							num3 = -2;
						}
					}
					IL_6A:
					continue;
					Block_1:
					num2 = -5;
					continue;
					IL_A8:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.set_GroupBox2(GroupBox)).MethodHandle;
					num2 = -6;
				}
			}
			IL_130:
			bool flag2 = false;
			goto IL_136;
			IL_133:
			flag2 = true;
			IL_136:
			if (!flag2)
			{
				this.rs.MoveNext();
				for (;;)
				{
					int num4 = Form6.sbdifomqugmuko(61);
					for (;;)
					{
						num4 ^= 79;
						switch (num4 + 85)
						{
						case 0:
							num4 = -1;
							continue;
						case 1:
							this.display();
							num4 = -32;
							continue;
						case 2:
							num4 = -29;
							continue;
						case 3:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.set_cmdFirst(Button)).MethodHandle;
							num4 = -31;
							continue;
						}
						case 4:
							num4 = Form12.wsyoqrrjsoniul(54);
							continue;
						case 5:
							goto IL_1EA;
						}
						break;
					}
				}
				IL_1EA:;
			}
			else
			{
				Interaction.MsgBox("Record Not Found.", MsgBoxStyle.Information, null);
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00023D08 File Offset: 0x00021F08
		public void reload()
		{
			for (;;)
			{
				IL_BB:
				int num = 3;
				int num2 = -26;
				for (;;)
				{
					num2 ^= 84;
					for (;;)
					{
						IL_50:
						int num3 = 14;
						int num4 = -5;
						for (;;)
						{
							num4 ^= 87;
							switch (num4 + 87)
							{
							case 0:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.eiydpywoxrtbjb(object, EventArgs)).MethodHandle;
								num4 = Form7.mqgfoefwabbyeu(24);
								continue;
							}
							case 1:
								goto IL_50;
							case 2:
								switch (num3)
								{
								case 86:
									break;
								case 87:
									switch (num2 + 81)
									{
									case 0:
										goto IL_BB;
									case 1:
										goto IL_C5;
									case 2:
										switch (num)
										{
										case 82:
											num = 1;
											goto IL_0B;
										case 83:
											num = 2;
											goto IL_0B;
										case 84:
											this.rs.Open("Select * from StudentsProfile", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
											num = 6;
											goto IL_0B;
										case 85:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.set_txtAdmNo(TextBox)).MethodHandle;
											num = 0;
											goto IL_0B;
										}
										case 86:
											this.rs.Close();
											num = 7;
											goto IL_0B;
										case 87:
											return;
										}
										goto Block_3;
									case 3:
										break;
									default:
										num3 = 15;
										goto IL_19;
									}
									IL_0B:
									num ^= 85;
									break;
								case 88:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.get_lblPassword()).MethodHandle;
									num3 = 1;
									goto IL_19;
								}
								case 89:
									goto IL_B6;
								default:
									num4 = -3;
									continue;
								}
								num2 = Form12.wsyoqrrjsoniul(56);
								num3 = 0;
								goto IL_19;
							case 3:
								goto IL_19;
							}
							IL_32:
							num4 = Form2.uwpnsrqhswlmjh(42);
							continue;
							IL_19:
							num3 ^= 89;
							goto IL_32;
						}
					}
					IL_B6:
					continue;
					IL_C5:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.get_OpenFileDialog1()).MethodHandle;
					num2 = -28;
					continue;
					Block_3:
					num2 = -5;
				}
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00023E9C File Offset: 0x0002209C
		private void eiydpywoxrtbis(object em, EventArgs en)
		{
			for (;;)
			{
				int num = 59;
				for (;;)
				{
					switch (num ^ 91)
					{
					case 87:
						this.rs.Fields["FirstName"].Value = this.txtFirstName.Text;
						num = 2;
						continue;
					case 88:
						num = 58;
						continue;
					case 89:
						num = 5;
						continue;
					case 90:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.get_cboProgram()).MethodHandle;
						num = 1;
						continue;
					}
					case 91:
						num = 12;
						continue;
					case 92:
					{
						bool @checked;
						if (@checked)
						{
							num = 57;
							continue;
						}
						goto IL_127;
					}
					case 93:
						this.rs.Fields["DOB"].Value = this.DateTimePicker1.Value;
						num = 3;
						continue;
					case 94:
						this.rs.Fields["LastName"].Value = this.txtLastName.Text;
						num = 4;
						continue;
					case 95:
						num = 6;
						continue;
					case 96:
						this.rs.Fields["AdmNo"].Value = this.txtAdmNo.Text;
						num = 0;
						continue;
					case 97:
					{
						bool @checked = this.rbMale.Checked;
						num = 7;
						continue;
					}
					case 98:
						goto IL_124;
					}
					break;
				}
			}
			IL_124:
			bool flag = false;
			goto IL_12A;
			IL_127:
			flag = true;
			IL_12A:
			if (!flag)
			{
				this.rs.Fields["Gender"].Value = this.rbMale.Text;
				for (;;)
				{
					int num2 = Form2.uwpnsrqhswlmjh(44);
					for (;;)
					{
						num2 ^= 82;
						switch (num2 + 89)
						{
						case 0:
						{
							RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.get_cmdDelete()).MethodHandle;
							num2 = -11;
							continue;
						}
						case 1:
							num2 = -5;
							continue;
						case 2:
							num2 = -8;
							continue;
						case 3:
							goto IL_19C;
						}
						break;
					}
				}
				IL_19C:;
			}
			else
			{
				bool checked2 = this.rbFemale.Checked;
				if (checked2)
				{
					this.rs.Fields["Gender"].Value = this.rbFemale.Text;
				}
			}
			this.rs.Fields["Program"].Value = this.cboProgram.Text;
			for (;;)
			{
				int num3 = Form8.nxfpeikhibypgs(81);
				for (;;)
				{
					num3 ^= 88;
					switch (num3 + 84)
					{
					case 0:
						num3 = -21;
						continue;
					case 1:
					{
						bool flag2;
						if (flag2)
						{
							num3 = -32;
							continue;
						}
						goto IL_366;
					}
					case 2:
						this.rs.Fields["Password"].Value = this.txtPassword.Text;
						num3 = -12;
						continue;
					case 3:
					{
						RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.set_cmdEdit(Button)).MethodHandle;
						num3 = -9;
						continue;
					}
					case 4:
						this.rs.Fields["Photo"].Value = this.str;
						num3 = Form6.sbdifomqugmuko(64);
						continue;
					case 5:
						num3 = -24;
						continue;
					case 6:
						this.rs.Fields["Email"].Value = this.txtEmail.Text;
						num3 = -23;
						continue;
					case 7:
					{
						bool flag2 = Operators.CompareString(this.str, "", false) == 0;
						num3 = -11;
						continue;
					}
					case 8:
						num3 = -10;
						continue;
					case 9:
						this.rs.Fields["PhoneNo"].Value = this.txtPhone.Text;
						num3 = -17;
						continue;
					case 10:
						num3 = -19;
						continue;
					case 11:
						num3 = -22;
						continue;
					case 12:
						goto IL_363;
					}
					break;
				}
			}
			IL_363:
			bool flag3 = false;
			goto IL_369;
			IL_366:
			flag3 = true;
			IL_369:
			if (!flag3)
			{
				Interaction.MsgBox("Please Upload a Photo for the Student.", MsgBoxStyle.Critical, null);
			}
			else
			{
				for (;;)
				{
					int num4 = Form2.uwpnsrqhswlmjh(42);
					for (;;)
					{
						num4 ^= 85;
						switch (num4 + 89)
						{
						case 0:
							this.rs.Update(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
							num4 = Form7.mqgfoefwabbyeu(31);
							continue;
						case 1:
							num4 = -2;
							continue;
						case 2:
							Interaction.MsgBox("Record Saved Successfully.", MsgBoxStyle.Information, null);
							num4 = -14;
							continue;
						case 3:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.get_cmdNext()).MethodHandle;
							num4 = -1;
							continue;
						}
						case 4:
							goto IL_461;
						}
						break;
					}
				}
				IL_461:;
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0002430C File Offset: 0x0002250C
		private void eiydpywoxrtbit(object eo, EventArgs ep)
		{
			for (;;)
			{
				IL_CE:
				int num = 12;
				int num2 = Form7.mqgfoefwabbyeu(24);
				for (;;)
				{
					num2 ^= 85;
					for (;;)
					{
						IL_3F:
						int num3 = 1;
						int num4 = -6;
						for (;;)
						{
							num4 ^= 86;
							switch (num4 + 87)
							{
							case 0:
								goto IL_3F;
							case 1:
								switch (num3)
								{
								case 90:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.get_txtLastName()).MethodHandle;
									num3 = 0;
									goto IL_1C;
								}
								case 91:
									switch (num2 + 88)
									{
									case 0:
										switch (num)
										{
										case 83:
											num = 14;
											goto IL_0B;
										case 84:
											num = 3;
											goto IL_0B;
										case 85:
											this.display();
											num = 15;
											goto IL_0B;
										case 86:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.eiydpywoxrtbja(object, EventArgs)).MethodHandle;
											num = 13;
											goto IL_0B;
										}
										case 87:
											this.rs.MoveFirst();
											num = 8;
											goto IL_0B;
										case 88:
											return;
										}
										goto Block_2;
									case 1:
										goto IL_CE;
									case 2:
										goto IL_DE;
									case 3:
										break;
									default:
										num3 = 6;
										goto IL_1C;
									}
									IL_0B:
									num ^= 91;
									break;
								case 92:
									break;
								case 93:
									goto IL_A0;
								default:
									num4 = Form7.mqgfoefwabbyeu(25);
									continue;
								}
								num2 = Form7.mqgfoefwabbyeu(31);
								num3 = 7;
								goto IL_1C;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.get_Label5()).MethodHandle;
								num4 = -3;
								continue;
							}
							case 3:
								goto IL_1C;
							}
							IL_35:
							num4 = Form2.uwpnsrqhswlmjh(42);
							continue;
							IL_1C:
							num3 ^= 90;
							goto IL_35;
						}
					}
					IL_A0:
					continue;
					Block_2:
					num2 = -4;
					continue;
					IL_DE:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.eiydpywoxrtbiv(object, EventArgs)).MethodHandle;
					num2 = -1;
				}
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00024490 File Offset: 0x00022690
		private void eiydpywoxrtbiu(object eq, EventArgs er)
		{
			for (;;)
			{
				IL_D3:
				int num = 3;
				int num2 = 4;
				for (;;)
				{
					num2 ^= 86;
					for (;;)
					{
						IL_61:
						int num3 = 3;
						int num4 = -25;
						for (;;)
						{
							num4 ^= 85;
							switch (num4 + 81)
							{
							case 0:
								switch (num3)
								{
								case 79:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.get_cmdSave()).MethodHandle;
									num3 = 28;
									goto IL_1C;
								}
								case 80:
									switch (num2)
									{
									case 79:
										goto IL_9D;
									case 80:
										switch (num)
										{
										case 79:
											num = 2;
											goto IL_0B;
										case 80:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.get_cmdAdd()).MethodHandle;
											num = 1;
											goto IL_0B;
										}
										case 81:
											num = 5;
											goto IL_0B;
										case 82:
											this.rs.MoveLast();
											num = 30;
											goto IL_0B;
										case 83:
											this.display();
											num = 0;
											goto IL_0B;
										case 84:
											return;
										}
										goto Block_2;
									case 81:
										goto IL_D3;
									case 82:
										break;
									default:
										num3 = 2;
										goto IL_1C;
									}
									IL_0B:
									num ^= 81;
									break;
								case 81:
									break;
								case 82:
									goto IL_98;
								default:
									num4 = Form12.wsyoqrrjsoniul(54);
									continue;
								}
								num2 = 6;
								num3 = 1;
								goto IL_1C;
							case 1:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.set_txtFirstName(TextBox)).MethodHandle;
								num4 = -27;
								continue;
							}
							case 2:
								goto IL_61;
							case 3:
								goto IL_1C;
							}
							IL_35:
							num4 = Form2.uwpnsrqhswlmjh(44);
							continue;
							IL_1C:
							num3 ^= 83;
							goto IL_35;
						}
					}
					IL_98:
					continue;
					IL_9D:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.get_cmdUpdate()).MethodHandle;
					num2 = 25;
					continue;
					Block_2:
					num2 = 7;
				}
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00024604 File Offset: 0x00022804
		private void eiydpywoxrtbiv(object es, EventArgs et)
		{
			for (;;)
			{
				IL_5B:
				int num = 5;
				int num2 = -10;
				for (;;)
				{
					num2 ^= 89;
					for (;;)
					{
						int num3 = 4;
						for (;;)
						{
							switch (num3 ^ 87)
							{
							case 82:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.get_GroupBox3()).MethodHandle;
								num3 = 5;
								continue;
							}
							case 83:
								switch (num2 + 84)
								{
								case 0:
									goto IL_5B;
								case 1:
									switch (num)
									{
									case 86:
										num = 11;
										goto IL_08;
									case 87:
									{
										bool flag = !this.rs.EOF;
										num = 4;
										goto IL_08;
									}
									case 88:
									{
										bool flag;
										if (flag)
										{
											num = 7;
											goto IL_08;
										}
										goto IL_EC;
									}
									case 89:
										this.rs.MoveNext();
										num = 10;
										goto IL_08;
									case 90:
									{
										RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.eiydpywoxrtbjc(object, EventArgs)).MethodHandle;
										num = 6;
										goto IL_08;
									}
									case 91:
										goto IL_E9;
									}
									goto Block_1;
								case 2:
									goto IL_88;
								case 3:
									break;
								default:
									num3 = 3;
									continue;
								}
								IL_08:
								num ^= 92;
								goto IL_4C;
							case 84:
								goto IL_4C;
							case 85:
								goto IL_59;
							}
							break;
							IL_4C:
							num2 = Form12.wsyoqrrjsoniul(58);
							num3 = 2;
						}
					}
					IL_59:
					continue;
					Block_1:
					num2 = -11;
					continue;
					IL_88:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.set_Label1(Label)).MethodHandle;
					num2 = Form7.mqgfoefwabbyeu(32);
				}
			}
			IL_E9:
			bool flag2 = false;
			goto IL_EF;
			IL_EC:
			flag2 = true;
			IL_EF:
			if (!flag2)
			{
				this.display();
			}
			else
			{
				for (;;)
				{
					int num4 = 13;
					for (;;)
					{
						switch (num4 ^ 86)
						{
						case 91:
							this.rs.MoveFirst();
							num4 = 9;
							continue;
						case 92:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.get_txtPhone()).MethodHandle;
							num4 = 10;
							continue;
						}
						case 93:
							this.display();
							num4 = 8;
							continue;
						case 94:
							num4 = 54;
							continue;
						case 95:
							num4 = 11;
							continue;
						case 96:
							goto IL_1B2;
						}
						break;
					}
				}
				IL_1B2:;
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000247C4 File Offset: 0x000229C4
		private void eiydpywoxrtbiw(object eu, EventArgs ev)
		{
			for (;;)
			{
				IL_94:
				int num = 11;
				int num2 = -4;
				for (;;)
				{
					num2 ^= 87;
					for (;;)
					{
						int num3 = Form12.wsyoqrrjsoniul(40);
						for (;;)
						{
							num3 ^= 83;
							switch (num3 + 85)
							{
							case 0:
								switch (num2 + 88)
								{
								case 0:
									switch (num)
									{
									case 89:
										this.rs.MovePrevious();
										num = 8;
										goto IL_0B;
									case 90:
										num = 15;
										goto IL_0B;
									case 91:
									{
										bool bof;
										if (bof)
										{
											num = 12;
											goto IL_0B;
										}
										goto IL_102;
									}
									case 92:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.get_cmdSave()).MethodHandle;
										num = 14;
										goto IL_0B;
									}
									case 93:
									{
										bool bof = this.rs.BOF;
										num = 9;
										goto IL_0B;
									}
									case 94:
										goto IL_FF;
									}
									goto Block_1;
								case 1:
									goto IL_94;
								case 2:
									goto IL_9F;
								case 3:
									break;
								default:
									num3 = -2;
									continue;
								}
								IL_0B:
								num ^= 82;
								goto IL_56;
							case 1:
							{
								RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.set_Label7(Label)).MethodHandle;
								num3 = -1;
								continue;
							}
							case 2:
								goto IL_56;
							case 3:
								goto IL_69;
							}
							break;
							IL_56:
							num2 = Form7.mqgfoefwabbyeu(25);
							num3 = Form7.mqgfoefwabbyeu(31);
						}
					}
					IL_69:
					continue;
					Block_1:
					num2 = -2;
					continue;
					IL_9F:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.set_cmdPrevious(Button)).MethodHandle;
					num2 = Form7.mqgfoefwabbyeu(31);
				}
			}
			IL_FF:
			bool flag = false;
			goto IL_105;
			IL_102:
			flag = true;
			IL_105:
			if (!flag)
			{
				this.rs.MoveLast();
				for (;;)
				{
					int num4 = Form12.wsyoqrrjsoniul(52);
					for (;;)
					{
						num4 ^= 80;
						switch (num4 + 79)
						{
						case 0:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.set_txtLastName(TextBox)).MethodHandle;
							num4 = -31;
							continue;
						}
						case 1:
							num4 = -27;
							continue;
						case 2:
							num4 = -28;
							continue;
						case 3:
							this.display();
							num4 = -30;
							continue;
						case 4:
							num4 = -26;
							continue;
						case 5:
							goto IL_193;
						}
						break;
					}
				}
				IL_193:;
			}
			else
			{
				this.display();
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00024994 File Offset: 0x00022B94
		private void eiydpywoxrtbix(object ew, EventArgs ex)
		{
			for (;;)
			{
				IL_61:
				int num = 7;
				int num2 = 7;
				for (;;)
				{
					num2 ^= 82;
					for (;;)
					{
						int num3 = Form7.mqgfoefwabbyeu(31);
						for (;;)
						{
							num3 ^= 91;
							switch (num3 + 91)
							{
							case 0:
								goto IL_37;
							case 1:
								switch (num2)
								{
								case 82:
									goto IL_61;
								case 83:
									switch (num)
									{
									case 86:
									{
										RuntimeMethodHandle runtimeMethodHandle = methodof(Form9..ctor()).MethodHandle;
										num = 6;
										goto IL_08;
									}
									case 87:
									{
										string value = Conversions.ToString((int)Interaction.MsgBox("Do You Really Want to Delete This Student Profile?", MsgBoxStyle.YesNo | MsgBoxStyle.Critical, "Deletion Confirmation"));
										num = 9;
										goto IL_08;
									}
									case 88:
									{
										bool flag;
										if (flag)
										{
											num = 10;
											goto IL_08;
										}
										goto IL_F0;
									}
									case 89:
									{
										string value;
										bool flag = Conversions.ToDouble(value) == 6.0;
										num = 8;
										goto IL_08;
									}
									case 90:
										goto IL_ED;
									}
									goto Block_1;
								case 84:
									goto IL_8A;
								case 85:
									break;
								default:
									num3 = -2;
									continue;
								}
								IL_08:
								num ^= 80;
								goto IL_37;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.get_lblPassword()).MethodHandle;
								num3 = -4;
								continue;
							}
							case 3:
								goto IL_5F;
							}
							break;
							IL_37:
							num2 = 1;
							num3 = -13;
						}
					}
					IL_5F:
					continue;
					Block_1:
					num2 = 0;
					continue;
					IL_8A:
					RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.get_GroupBox2()).MethodHandle;
					num2 = 6;
				}
			}
			IL_ED:
			bool flag2 = false;
			goto IL_F3;
			IL_F0:
			flag2 = true;
			IL_F3:
			if (!flag2)
			{
				this.rs.Delete(AffectEnum.adAffectCurrent);
				for (;;)
				{
					int num4 = 13;
					for (;;)
					{
						switch (num4 ^ 80)
						{
						case 91:
							Interaction.MsgBox("Record Deleted Successfully.", MsgBoxStyle.Information, "Message");
							num4 = 12;
							continue;
						case 92:
							this.rs.Update(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
							num4 = 49;
							continue;
						case 93:
							num4 = 11;
							continue;
						case 94:
							num4 = 51;
							continue;
						case 95:
							this.refreshData();
							num4 = 50;
							continue;
						case 96:
						{
							RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.get_GroupBox2()).MethodHandle;
							num4 = 48;
							continue;
						}
						case 97:
							num4 = 15;
							continue;
						case 98:
							num4 = 14;
							continue;
						case 99:
							goto IL_1FC;
						}
						break;
					}
				}
				IL_1FC:;
			}
			else
			{
				Interaction.MsgBox("Record Not Deleted.", MsgBoxStyle.Information, "Message");
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00024BBC File Offset: 0x00022DBC
		private void eiydpywoxrtbiy(object ey, EventArgs ez)
		{
			for (;;)
			{
				IL_47:
				int num = 2;
				int num2 = 8;
				for (;;)
				{
					switch (num2 ^ 82)
					{
					case 87:
					{
						RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.set_Label7(Label)).MethodHandle;
						num2 = 5;
						continue;
					}
					case 88:
						switch (num)
						{
						case 85:
							this.rs.Fields["FirstName"].Value = this.txtFirstName.Text;
							num = 14;
							goto IL_08;
						case 86:
							num = 5;
							goto IL_08;
						case 87:
							num = 3;
							goto IL_08;
						case 88:
							num = 13;
							goto IL_08;
						case 89:
							num = 4;
							goto IL_08;
						case 90:
							this.rs.Fields["AdmNo"].Value = this.txtAdmNo.Text;
							num = 0;
							goto IL_08;
						case 91:
							this.rs.Fields["DOB"].Value = this.DateTimePicker1.Value;
							num = 1;
							goto IL_08;
						case 92:
						{
							bool @checked = this.rbMale.Checked;
							num = 6;
							goto IL_08;
						}
						case 93:
							this.rs.Fields["LastName"].Value = this.txtLastName.Text;
							num = 15;
							goto IL_08;
						case 94:
						{
							bool @checked;
							if (@checked)
							{
								num = 56;
								goto IL_08;
							}
							goto IL_14D;
						}
						case 95:
						{
							RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.get_txtEmail()).MethodHandle;
							num = 7;
							goto IL_08;
						}
						case 96:
							goto IL_14A;
						default:
							num2 = 11;
							continue;
						}
						break;
					case 89:
						goto IL_47;
					case 90:
						goto IL_08;
					}
					IL_23:
					num2 = 10;
					continue;
					IL_08:
					num ^= 88;
					goto IL_23;
				}
			}
			IL_14A:
			bool flag = false;
			goto IL_150;
			IL_14D:
			flag = true;
			IL_150:
			if (!flag)
			{
				this.rs.Fields["Gender"].Value = this.rbMale.Text;
				for (;;)
				{
					int num3 = Form12.wsyoqrrjsoniul(51);
					for (;;)
					{
						num3 ^= 86;
						switch (num3 + 81)
						{
						case 0:
							num3 = -26;
							continue;
						case 1:
							num3 = -28;
							continue;
						case 2:
						{
							RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.get_DateTimePicker1()).MethodHandle;
							num3 = Form2.uwpnsrqhswlmjh(50);
							continue;
						}
						case 3:
							goto IL_1C7;
						}
						break;
					}
				}
				IL_1C7:;
			}
			else
			{
				bool checked2 = this.rbFemale.Checked;
				if (checked2)
				{
					this.rs.Fields["Gender"].Value = this.rbFemale.Text;
				}
			}
			this.rs.Fields["Program"].Value = this.cboProgram.Text;
			for (;;)
			{
				int num4 = 2;
				for (;;)
				{
					switch (num4 ^ 90)
					{
					case 84:
						num4 = 58;
						continue;
					case 85:
						this.rs.Fields["Password"].Value = this.txtPassword.Text;
						num4 = 14;
						continue;
					case 86:
						num4 = 15;
						continue;
					case 87:
						num4 = 59;
						continue;
					case 88:
						num4 = 0;
						continue;
					case 89:
						this.rs.Fields["Photo"].Value = this.str;
						num4 = 12;
						continue;
					case 90:
						this.rs.Fields["PhoneNo"].Value = this.txtPhone.Text;
						num4 = 4;
						continue;
					case 91:
						this.rs.Update(RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
						num4 = 13;
						continue;
					case 92:
					{
						RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.eiydpywoxrtbis(object, EventArgs)).MethodHandle;
						num4 = 6;
						continue;
					}
					case 93:
						this.rs.Fields["Email"].Value = this.txtEmail.Text;
						num4 = 5;
						continue;
					case 94:
						num4 = 7;
						continue;
					case 95:
						num4 = 3;
						continue;
					case 96:
						Interaction.MsgBox("Record Updated Successfully.", MsgBoxStyle.Information, null);
						num4 = 1;
						continue;
					case 97:
						return;
					}
					break;
				}
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00024FCD File Offset: 0x000231CD
		private void eiydpywoxrtbiz(object fa, EventArgs fb)
		{
			this.display();
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00024FDC File Offset: 0x000231DC
		private void eiydpywoxrtbja(object fc, EventArgs fd)
		{
			for (;;)
			{
				IL_F7:
				int num = Form12.wsyoqrrjsoniul(54);
				int num2 = 2;
				for (;;)
				{
					num2 ^= 84;
					for (;;)
					{
						IL_42:
						int num3 = 8;
						int num4 = -4;
						for (;;)
						{
							num4 ^= 87;
							switch (num4 + 88)
							{
							case 0:
								goto IL_42;
							case 1:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.set_cmdUpdate(Button)).MethodHandle;
								num4 = -2;
								continue;
							}
							case 2:
								switch (num3)
								{
								case 86:
									break;
								case 87:
								{
									RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.clear()).MethodHandle;
									num3 = 7;
									goto IL_1C;
								}
								case 88:
									switch (num2)
									{
									case 83:
										goto IL_BA;
									case 84:
										switch (num + 80)
										{
										case 0:
											this.rs.Open("Select * from StudentsProfile where AdmNo = '" + this.txtAdmNo.Text + "'", this.con, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockPessimistic, -1);
											num = -29;
											goto IL_0B;
										case 1:
											num = -26;
											goto IL_0B;
										case 2:
											this.rs.Close();
											num = -25;
											goto IL_0B;
										case 3:
										{
											bool flag;
											if (flag)
											{
												num = -31;
												goto IL_0B;
											}
											goto IL_199;
										}
										case 4:
										{
											RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.set_GroupBox2(GroupBox)).MethodHandle;
											num = -30;
											goto IL_0B;
										}
										case 5:
											num = -32;
											goto IL_0B;
										case 6:
										{
											bool flag = !this.rs.EOF;
											num = -27;
											goto IL_0B;
										}
										case 7:
											goto IL_196;
										}
										goto Block_3;
									case 85:
										goto IL_F7;
									case 86:
										break;
									default:
										num3 = 6;
										goto IL_1C;
									}
									IL_0B:
									num ^= 86;
									break;
								case 89:
									goto IL_B5;
								default:
									num4 = Form7.mqgfoefwabbyeu(25);
									continue;
								}
								num2 = 0;
								num3 = 9;
								goto IL_1C;
							case 3:
								goto IL_1C;
							}
							IL_37:
							num4 = Form7.mqgfoefwabbyeu(31);
							continue;
							IL_1C:
							num3 ^= 80;
							goto IL_37;
						}
					}
					IL_B5:
					continue;
					IL_BA:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.get_txtEmail()).MethodHandle;
					num2 = 7;
					continue;
					Block_3:
					num2 = 1;
				}
			}
			IL_196:
			bool flag2 = false;
			goto IL_19C;
			IL_199:
			flag2 = true;
			IL_19C:
			if (!flag2)
			{
				this.display();
				this.reload();
			}
			else
			{
				Interaction.MsgBox("Record Not Found.", MsgBoxStyle.Information, null);
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000251E0 File Offset: 0x000233E0
		private void eiydpywoxrtbjb(object fe, EventArgs ff)
		{
			for (;;)
			{
				IL_B3:
				int num = 5;
				int num2 = 0;
				for (;;)
				{
					num2 ^= 92;
					for (;;)
					{
						IL_3C:
						int num3 = 1;
						int num4 = -5;
						for (;;)
						{
							num4 ^= 85;
							switch (num4 + 85)
							{
							case 0:
								goto IL_3C;
							case 1:
							{
								RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.set_cmdEdit(Button)).MethodHandle;
								num4 = -7;
								continue;
							}
							case 2:
								switch (num3)
								{
								case 82:
									break;
								case 83:
									switch (num2)
									{
									case 89:
										goto IL_B3;
									case 90:
										goto IL_BC;
									case 91:
										switch (num)
										{
										case 89:
											num = 3;
											goto IL_0B;
										case 90:
											yupufqwjlhlkfh.whvgmsxtmdbkxx.hcphoarosyelxe.Show();
											num = 4;
											goto IL_0B;
										case 91:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.get_Label4()).MethodHandle;
											num = 2;
											goto IL_0B;
										}
										case 92:
											base.Hide();
											num = 0;
											goto IL_0B;
										case 93:
											num = 7;
											goto IL_0B;
										case 94:
											return;
										}
										goto Block_3;
									case 92:
										break;
									default:
										num3 = 0;
										goto IL_19;
									}
									IL_0B:
									num ^= 89;
									break;
								case 84:
								{
									RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.Dispose(bool)).MethodHandle;
									num3 = 6;
									goto IL_19;
								}
								case 85:
									goto IL_AE;
								default:
									num4 = Form7.mqgfoefwabbyeu(24);
									continue;
								}
								num2 = 7;
								num3 = 7;
								goto IL_19;
							case 3:
								goto IL_19;
							}
							IL_32:
							num4 = Form12.wsyoqrrjsoniul(40);
							continue;
							IL_19:
							num3 ^= 82;
							goto IL_32;
						}
					}
					IL_AE:
					continue;
					IL_BC:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.set_Label5(Label)).MethodHandle;
					num2 = 6;
					continue;
					Block_3:
					num2 = 5;
				}
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00025358 File Offset: 0x00023558
		private void eiydpywoxrtbjc(object fg, EventArgs fh)
		{
			for (;;)
			{
				IL_B1:
				int num = 6;
				int num2 = 8;
				for (;;)
				{
					num2 ^= 81;
					for (;;)
					{
						IL_52:
						int num3 = Form7.mqgfoefwabbyeu(32);
						int num4 = -3;
						for (;;)
						{
							num4 ^= 86;
							switch (num4 + 88)
							{
							case 0:
								switch (num3 + 92)
								{
								case 0:
								{
									RuntimeMethodHandle runtimeMethodHandle = methodof(Form9.set_cmdLast(Button)).MethodHandle;
									num3 = Form7.mqgfoefwabbyeu(29);
									goto IL_1C;
								}
								case 1:
									switch (num2)
									{
									case 86:
										goto IL_B1;
									case 87:
										goto IL_BA;
									case 88:
										switch (num)
										{
										case 81:
											this.txtPassword.Visible = true;
											num = 1;
											goto IL_0B;
										case 82:
											num = 5;
											goto IL_0B;
										case 83:
											num = 2;
											goto IL_0B;
										case 84:
										{
											RuntimeMethodHandle runtimeMethodHandle2 = methodof(Form9.get_cmdPrevious()).MethodHandle;
											num = 7;
											goto IL_0B;
										}
										case 85:
											this.lblPassword.Visible = true;
											num = 0;
											goto IL_0B;
										case 86:
											return;
										}
										goto Block_2;
									case 89:
										break;
									default:
										num3 = -12;
										goto IL_1C;
									}
									IL_0B:
									num ^= 83;
									break;
								case 2:
									break;
								case 3:
									goto IL_AC;
								default:
									num4 = Form7.mqgfoefwabbyeu(25);
									continue;
								}
								num2 = 9;
								num3 = -11;
								goto IL_1C;
							case 1:
								goto IL_52;
							case 2:
							{
								RuntimeMethodHandle runtimeMethodHandle3 = methodof(Form9.get_txtPhone()).MethodHandle;
								num4 = -4;
								continue;
							}
							case 3:
								goto IL_1C;
							}
							IL_35:
							num4 = Form7.mqgfoefwabbyeu(24);
							continue;
							IL_1C:
							num3 ^= 82;
							goto IL_35;
						}
					}
					IL_AC:
					continue;
					IL_BA:
					RuntimeMethodHandle runtimeMethodHandle4 = methodof(Form9.set_GroupBox3(GroupBox)).MethodHandle;
					num2 = 6;
					continue;
					Block_2:
					num2 = 7;
				}
			}
		}

		// Token: 0x04000109 RID: 265
		private IContainer components;

		// Token: 0x04000130 RID: 304
		public Connection con;

		// Token: 0x04000131 RID: 305
		public Recordset rs;

		// Token: 0x04000132 RID: 306
		public string str;
	}
}
